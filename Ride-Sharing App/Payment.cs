using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Sharing_App
{
    internal class Payment
    { 
        public string Id {  get; set; }
        public string RideId { get; set; }  
        public string PassengerId { get; set; }
        public string DriverId { get; set; }    
        public decimal Amount { get; set; } 
        public string PayMethod { get; set; }
        public string PayType { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime DateTime { get; set; }  

    }
}
