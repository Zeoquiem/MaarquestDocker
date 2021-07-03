using Maarquest.WEB.Logic;
using Maarquest.WEB.Logic.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maarquest.WEB
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            }); ;

            #region Configuration de la session
            services.AddDistributedMemoryCache();

            services.AddSession(options =>
            {
                // Set a short timeout for easy testing.
                options.IdleTimeout = System.TimeSpan.FromSeconds(300);
                options.Cookie.HttpOnly = true;
                // Make the session cookie essential
                options.Cookie.IsEssential = true;
            });
            #endregion

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();

            services.AddHttpClient("MaarquestApi", options =>
            {
                options.BaseAddress = new Uri(Configuration["AppSettings:MaarquestApi"]);
                options.DefaultRequestHeaders.Add("Accept", "application/json");
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSingleton<IConfiguration>(Configuration);

            services.AddScoped<IMaarquestApiContext, MaarquestApiContext>();


            services.AddScoped<AddressService, AddressService>();
            services.AddScoped<CreditCardService, CreditCardService>();
            services.AddScoped<CustomerKitchenService, CustomerKitchenService>();
            services.AddScoped<CustomerService, CustomerService>();
            services.AddScoped<DeliveryProductService, DeliveryProductService>();
            services.AddScoped<DeliveryService, DeliveryService>();
            services.AddScoped<NotificationService, NotificationService>();
            services.AddScoped<OrderProductTypeService, OrderProductTypeService>();
            services.AddScoped<OrderService, OrderService>();
            services.AddScoped<PaymentMeanService, PaymentMeanService>();
            services.AddScoped<PaypalService, PaypalService>();
            services.AddScoped<PositionTypeService, PositionTypeService>();
            services.AddScoped<ProductCategoryService, ProductCategoryService>();
            services.AddScoped<ProductService, ProductService>();
            services.AddScoped<ProductTypeService, ProductTypeService>();
            services.AddScoped<PromotionCustomerService, PromotionCustomerService>();
            services.AddScoped<PromotionPackService, PromotionPackService>();
            services.AddScoped<PromotionService, PromotionService>();
            services.AddScoped<PromotionTypeService, PromotionTypeService>();
            services.AddScoped<ReceiptProductTypeService, ReceiptProductTypeService>();
            services.AddScoped<ReceiptService, ReceiptService>();
            services.AddScoped<RecommendationService, RecommendationService>();
            services.AddScoped<SupermarketOperatorFunctionService, SupermarketOperatorFunctionService>();
            services.AddScoped<SupermarketOperatorService, SupermarketOperatorService>();
            services.AddScoped<SupermarketService, SupermarketService>();
            services.AddScoped<SupermarketShelfService, SupermarketShelfService>();
            services.AddScoped<SupermarketStockService, SupermarketStockService>();
            services.AddScoped<SupplierContactRequestService, SupplierContactRequestService>();
            services.AddScoped<SupplierOperatorFunctionService, SupplierOperatorFunctionService>();
            services.AddScoped<SupplierOperatorService, SupplierOperatorService>();
            services.AddScoped<SupplierProductRequestService, SupplierProductRequestService>();
            services.AddScoped<SupplierService, SupplierService>();
            services.AddScoped<SupplierStorageService, SupplierStorageService>();
            services.AddScoped<TransportMeanService, TransportMeanService>();
            services.AddScoped<UserTypeService, UserTypeService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseCookiePolicy(new CookiePolicyOptions()
            {
                MinimumSameSitePolicy = SameSiteMode.Strict
            });

            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{area=Supplier}/{controller=Home}/{action=Index}");

                endpoints.MapAreaControllerRoute(
                    name: "Supplier",
                    areaName: "Supplier",
                    pattern: "{area=Supplier}/{controller}/{action}/{id?}") ;
            });
        }
    }
}
