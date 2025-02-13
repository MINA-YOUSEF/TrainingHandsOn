using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Sharing_App
{
    internal class Rating
    {
       public int RatingValue {  get; set; } //0->5
        public Ride RideDatails {  get; private set; }  
         public Feedback? feedback { get; set; } // if the rating less than 2 and driver and passnger detailes in Ride 
    }
}
