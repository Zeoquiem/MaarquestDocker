using Maarquest.WEB.Logic.Models;
using Maarquest.WEB.Logic.Services;
using Maarquest.WEB.Areas.Supplier.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Maarquest.WEB.Areas.Supplier.Controllers
{
    [Area("Supplier")]
    public class UserController : Controller
    {
        AddressService _addressService;
        SupplierService _supplierService;
        SupplierContactRequestService _supplierContactRequestService;
        SupplierOperatorService _supplierOperatorService;
        SupplierOperatorFunctionService _supplierOperatorFunctionService;

        public UserController(
            AddressService addressService,
            SupplierService supplierService,
            SupplierContactRequestService supplierContactRequestService,
            SupplierOperatorService supplierOperatorService,
            SupplierOperatorFunctionService supplierOperatorFunctionService)
        {
            _addressService = addressService;
            _supplierService = supplierService;
            _supplierContactRequestService = supplierContactRequestService;
            _supplierOperatorService = supplierOperatorService;
            _supplierOperatorFunctionService = supplierOperatorFunctionService;
        }

        public IActionResult Settings()
        {
            return View();
        }
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View("../Home/Index");
            }
            else
            {
                return View();
            }
        }
        public async Task<IActionResult> LoginResult(LoginModel model)
        {
            if (!User.Identity.IsAuthenticated)
            {
                if (model.Identifier != null || model.Password != null)
                {
                    SupplierOperator requestUser = new SupplierOperator { Username = model.Identifier, Password = model.Password };
                    SupplierOperator user = null;
                    SupplierOperatorFunction userFunction = null; 
                    try
                    {
                        user = await _supplierOperatorService.GetByLogIn(requestUser);
                        userFunction = await _supplierOperatorFunctionService.Get(user.SupplierOperatorFunctionId);
                    }
                    finally
                    {

                    }
                    if (user != null)
                    {
                        var claims = new List<Claim> {
                        new Claim(ClaimTypes.Name, user.Username),
                        new Claim(ClaimTypes.Role, userFunction.Label)
                    };

                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                        await HttpContext.SignInAsync(
                            CookieAuthenticationDefaults.AuthenticationScheme,
                            new ClaimsPrincipal(claimsIdentity),
                            new AuthenticationProperties
                            {
                                IsPersistent = model.RememberMe
                            }
                       );
                        return View("../Home/Index");
                    }
                    else
                    {
                        return View("Login");
                    }
                }
                else
                {
                    return View("Login");
                }
            }
            return View("../Home/Index");
        }

        public async Task<IActionResult> LogOutAsync()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return View("Login");
        }

        public IActionResult AccountManagement()
        {
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult Register()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View("../Home/Index");
            }
            else
            {
                return View();
            }
        }

        public async Task<IActionResult> RegisterResult(RegisterModel model)
        {
            if (!User.Identity.IsAuthenticated)
            {
                if (model != null && _addressService.Verify(model.Address))
                {
                    Address supplierAddress = model.Address;
                    Address addressResult = null;
                    try
                    {
                        addressResult = await _addressService.Add(supplierAddress);
                    }
                    finally { }
                    Logic.Models.Supplier supplier = new Logic.Models.Supplier
                    {
                        AddressId = addressResult.AddressId,
                        CompanyName = model.Name,
                        CompanySign = model.Sign,
                        Siret = model.Siret,
                        Fax = model.Fax,
                        Tel = model.Phone,
                        IsReady = false
                    };
                    Logic.Models.Supplier supplierResult = null;
                    try
                    {
                        supplierResult = await _supplierService.Add(supplier);
                    }
                    finally { }
                    SupplierContactRequest supplierContactRequest = new SupplierContactRequest
                    {
                        SupplierId = supplierResult.SupplierId,
                        IsTreated = false
                    };

                    return View("Login");
                }
                else return View("Register");
            }
            else return View("../Home/Index");
        }
    }
}
