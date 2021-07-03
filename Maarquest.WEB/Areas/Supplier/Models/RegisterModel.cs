using Maarquest.WEB.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maarquest.WEB.Areas.Supplier.Models
{
    public class RegisterModel
    {
        public string Name { get; set; }
        public string Sign { get; set; }
        public string Siret { get; set; }
        public Address Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string ContactMail { get; set; }
        public string ContactPhone { get; set; }
    }
}
