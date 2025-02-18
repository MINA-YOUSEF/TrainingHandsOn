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
        public Passenger passenger { get; set; }
        public Location StartLocation { get; set; }
        public Location EndLocation { get; set; }
        public string Status { get; set; } //(Pending, Ongoing, Completed, Canceled)
        public DateTime? StartTime { get; set; }// -?- at the start time because the ride can be canceled before starting or canceled when pending.
        public DateTime? EndTime { get; set; }
        public Payment PaymentDetails { get; set; }
        public Rating? rating { get; set; }    // Not necessary, the passenger rating .
        public Feedback? feedback { get; set; }  // Not necessary, the passenger feedback  .


        // void RequestRide (); 
        public void GetRideDetails()
        {
            Console.WriteLine($"Ride details :");
            Console.WriteLine($"Ride Id : {Id}");
            Console.WriteLine($"fare :{Fare:C}");
            Console.WriteLine($"Driver :{driver?.Name??"N/A"}");
            Console.WriteLine($"Passenger :{passenger?.Name ??"N/A"}");
            Console.WriteLine($"Start location{StartLocation?.Latitude} : {StartLocation?.Longitude}");
            Console.WriteLine($"End location{EndLocation?.Latitude} : {EndLocation?.Longitude}");
            Console.WriteLine($"Status : {Status}");
            Console.WriteLine($"Start Time: {(StartTime.HasValue ? StartTime.ToString() : "Not Started")}");
            Console.WriteLine($"End Time: {(EndTime.HasValue ? EndTime.ToString() : "Not Ended")}"); 
            Console.WriteLine($"Payment Method: {PaymentDetails?.PayMethod ?? "N/A"}");
            Console.WriteLine($"Rating: {(rating?.RatingValue==0 ? rating.ToString() : "No Rating")}");
            Console.WriteLine($"Feedback: {feedback?.BodyFeedback ?? "No Feedback"}");
            Console.WriteLine("__________________________________");
        }

    }
}
