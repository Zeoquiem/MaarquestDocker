using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.API.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public int? AddressId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public DateTime Birthdate { get; set; }
        public string Gender { get; set; }
        public string Tel { get; set; }

    }
}
