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
        public Driver Driver { get; set; }
        public Ride RideDetails {  get; set; }  

        
    }
}
