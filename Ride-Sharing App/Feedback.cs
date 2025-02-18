using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Sharing_App
{
    internal class Feedback
    {
        public string BodyFeedback {  get; set; }    
        public  string id {  get; set; }   
        public DateTime FeedbackdateTime { get; set; }  
        public Passenger FeekbackOwner { get; set; }
        public Driver driver { get; set; }
        public Ride RideDetails {  get; set; }


      public  Feedback( string bodyFeedback)
        {
            this.BodyFeedback = bodyFeedback;
        }

        public void GetFeedbackDetails()
        {
            Console.WriteLine($"Feedback Time: {FeedbackdateTime}");
            Console.WriteLine($"Feedback No. : {id}");
            Console.WriteLine($"From: {FeekbackOwner.Name}");
            Console.WriteLine($"To: {driver.Name}");
            Console.WriteLine($"Feedback details: {BodyFeedback}");
            Console.WriteLine($"The ride details:"); RideDetails?.GetRideDetails();
            Console.WriteLine("__________________________________");
        }


        
    }
}
