using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DonateKart_Backend.Logger;
using DonateKart_Backend.Models;

namespace DonateKart_Backend.Controllers
{
    
    public class UserController : ControllerBase
    {
        private readonly IFileLogger fileLogger;
        UserController(IFileLogger fileLogger)
        {
            this.fileLogger = fileLogger; 
        }

        [HttpPost]
        public void Createuser(donor Donor)
        {
            if (Donor == null) throw new ArgumentNullException(nameof(donor));
            this.fileLogger.AddtoLogfile("Name : " + Donor.Name + ", Email ID : " + Donor.Email + ", Phone Number : " + Donor.PhoneNumber);
        }

        [HttpPost]
        public void SendEmail(emailDetails EmailDetails)
        {
            
            
                if (EmailDetails == null) throw new ArgumentNullException(nameof(EmailDetails));
                this.fileLogger.AddtoLogfile("To :" + EmailDetails.ToEmail);
                this.fileLogger.AddtoLogfile("From :" + EmailDetails.FromEmail);
                this.fileLogger.AddtoLogfile("Subject:" + EmailDetails.Subject);
                this.fileLogger.AddtoLogfile("Body :" + EmailDetails.Body);
            
        }


    }
}
