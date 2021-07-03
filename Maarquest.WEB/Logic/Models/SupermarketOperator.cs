using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Models
{
    public class SupermarketOperator
    {
        public int SupermarketOperatorId { get; set; }
        public int SupermarketId { get; set; }
        public int SupermarketOperatorFunctionId { get; set; }
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
