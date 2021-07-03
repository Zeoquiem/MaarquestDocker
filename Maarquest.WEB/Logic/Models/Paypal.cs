using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Models
{
    public class Paypal
    {
        public int PaypalId { get; set; }
        public bool IsConnected { get; set; }
        public string IdentifiantPaypal { get; set; }
    }
}
