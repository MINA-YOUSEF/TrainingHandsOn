using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Sharing_App
{
    internal class Ride
    { 
        public string Id { get; set; }
        public decimal Fare { get; set; } 
        public Driver driver { get; set; }  
        public Passenger Passenger { get; set; }
        public Location StartLocation { get; set; }
        public Location EndLocation { get; set; }
        public string Status { get; set; } //(Pending, Ongoing, Completed, Canceled)
        public DateTime StartTime { get; set; } 
        public DateTime? EndTime { get; set; }
        public Payment PaymentDetails {  get; set; } 
    }
}
