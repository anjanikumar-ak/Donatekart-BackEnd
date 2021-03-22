using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonateKart_Backend.Models
{
    public class emailDetails
    {
        public string ToEmail { get; set; }
        public string FromEmail{ get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }

    }
}
