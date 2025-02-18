using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Sharing_App
{
    internal class Passenger :AppUser
    {
        public string Information { get; set; }
        public List<Ride> RideHistory { get; set; }=new List<Ride>();
        public Wallet PassangerWallt { get; set; } =new Wallet();
        public Location CurrentLocation { get; set; }
        //Method
        public bool StartRide() { return true; }
        public bool CancelRide () { return true; }  
        //Done .

        public void UpdateInfo()
        {
            Console.WriteLine("Enter new name : ");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter new email : ");
            this.Email = Console.ReadLine();
            Console.WriteLine("Enter new Id : ");
            this.Id = Console.ReadLine();
            Console.WriteLine("Enter new phone number : ");
            this.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter new information : ");
            this.Information = Console.ReadLine();
        }
        public void AddBalance()
        {
           
            
                decimal AddBalnce = 0;
                Console.WriteLine($"Balance in wallet : {PassangerWallt.Balance}");
                Console.WriteLine("Enter the adding amount :");
                string input = Console.ReadLine();
                if (decimal.TryParse(input, out AddBalnce) && AddBalnce <= 10000&& AddBalnce > 0)
                {
                    decimal balance = PassangerWallt.AddBalance(AddBalnce);
                    Console.WriteLine($"Done adding \n The wallet balance :{balance}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid decimal number  .");
                }

            }
        //Done .
        public void Getinformation()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"ID : {Id}");
            Console.WriteLine($"Email : {Email}");
            Console.WriteLine($"Phone no. : {PhoneNumber}");
            Console.WriteLine($"Information : {Information}");
        }
        //Done .
        public void ViewRideHistory()
        {
            if (RideHistory.Count > 0)
            {
                Console.WriteLine("The list of history ride :");
                foreach (var ride in RideHistory)
                {
                    ride.GetRideDetails();
                }
            }
            else
            {
                Console.WriteLine("Ride list is empety. ");
            }
        }


    }
}
