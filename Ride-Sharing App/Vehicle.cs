using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Sharing_App
{
    internal class Vehicle
    {   public string VehicleType { get; set; }//(Car , Moto ,Truck,..)
        public string LicensePlate {  get; set; }
        public string Model { get; set; }
        public string Maker { get; set; }   
        public string Color {  get; set; }
        public int SeatingCapacity { get; set; }
        public  bool IsAvailable { get; set; }  

    }
}
