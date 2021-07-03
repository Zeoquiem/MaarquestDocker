﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.API.Models
{
    public class SupplierOperator
    {
        public int SupplierOperatorId { get; set; }
        public int SupplierId { get; set; }
        public int SupplierStorageId { get; set; }
        public int SupplierOperatorFunctionId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public DateTime Birthdate { get; set; }
        public string Gender { get; set; }
        public string Tel { get; set; }
    }
}
