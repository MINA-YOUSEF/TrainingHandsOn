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
        public Driver VehicleOwner { get; set; }
        public string Model { get; set; }
        public string Maker { get; set; }   
        public string Color {  get; set; }
        public int SeatingCapacity { get; set; }
        public bool IsAvailable { get; set; } = false; 

        public void NewVehicle(Driver Owener)
        {
            Console.WriteLine("Enter vehicle type : ");
            VehicleType = Console.ReadLine();
            Console.WriteLine("Enter license plate");
            LicensePlate = Console.ReadLine();
            VehicleOwner = Owener;
            Console.WriteLine("Enter vehicle model : ");
            Model = Console.ReadLine();
            Console.WriteLine("Enter vehicle Maker : ");
            Maker = Console.ReadLine();
            Console.WriteLine("Enter vehicle color : ");
            Color = Console.ReadLine();
            Console.WriteLine("Enter vehicle seating capacity : ");
            SeatingCapacity = int.Parse(Console.ReadLine());

           }
        public void UpdateVehicle(Driver Owener) {
                Console.WriteLine("Updating......");
                Console.WriteLine("Enter vehicle type : ");
                VehicleType = Console.ReadLine();
                Console.WriteLine("Enter license plate");
                LicensePlate = Console.ReadLine();
                VehicleOwner = Owener;
                Console.WriteLine("Enter vehicle model : ");
                Model = Console.ReadLine();
                Console.WriteLine("Enter vehicle Maker : ");
                Maker = Console.ReadLine();
                Console.WriteLine("Enter vehicle color : ");
                Color = Console.ReadLine();
                Console.WriteLine("Enter vehicle seating capacity : ");
                SeatingCapacity = int.Parse(Console.ReadLine());

               // return this;
            }
        public void GetVehicleInfo()
        {
            Console.WriteLine($"Vehicle type : {VehicleType}");
            Console.WriteLine($"License plate : {LicensePlate}");
            Console.WriteLine($"Vehicle owner -> Name: {this.VehicleOwner.Name} , Id: {this.VehicleOwner.Id}");
            Console.WriteLine($"Model : {Model}");
            Console.WriteLine($"Maker : {Maker}");
            Console.WriteLine($"Color : {Color}");
            Console.WriteLine($"Seating capacity : {SeatingCapacity}");
            Console.WriteLine($"Is available : {IsAvailable}");
            Console.WriteLine("------------------------");


        }

    }
}
