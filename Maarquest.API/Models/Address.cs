using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maarquest.API.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Receiver { get; set; }
        public string LignOne { get; set; }
        public string LignTwo { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
    }
}
