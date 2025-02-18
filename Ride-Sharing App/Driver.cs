using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Sharing_App
{
    internal class Driver :AppUser
    {
        public string Information {  get; set; }
        public List<Ride> RideHistory { get; set; }= new List<Ride>();
        public List<Vehicle> vehicles { get; set; } = new List<Vehicle>();
        public Vehicle  AvailableVehicle { get; private set; }
        readonly Wallet DriverWallet  =new Wallet();
        public bool IsActive { get; set; }  
        public Rating rating { get;}
        public Location CurrentLocation { get; set; }
        public List<Feedback> Feedbacks { get;  }=new List<Feedback>();
        public Driver() 
        {
            DriverWallet.UserId=Id;

        } 
        public Driver(string information,string name,string id , string eamil ,string phonenumber )
        {
            Information = information;
             Name   = name; 
            Id = id;
            Email = eamil;
            PhoneNumber = phonenumber;
          
          
        }

        // Methods 
        public bool IsAvailable (bool status) { return true; }
        public bool AcceptRide(Ride ride) { return true; }
        public bool CancelRide(Ride ride) { return true; }
        public bool CompleteRide(Ride ride) { return true; }
        //Done .
        public void  UpdateInfo ()
        {
            Console.WriteLine("Enter new name : ");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter new email : ");
            this.Email = Console.ReadLine();
            Console.WriteLine("Enter new phone number : ");
            this.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter new information : ");
            this.Information = Console.ReadLine();
        }
        //Done .
        public void UpdateVehicle()
        {
            GetVehicleList();
            Console.WriteLine("# Select With index .");
            int index;
            string input = Console.ReadLine();
            if (int.TryParse(input, out index)&&index<vehicles.Count&&index>=0)
            {
                vehicles[index].UpdateVehicle(this);
                Console.WriteLine("Updating successfully!");
                Console.WriteLine("Vehicle after updating :");
                vehicles[index].GetVehicleInfo();
            }
            else { Console.WriteLine("Invalid index .."); }

        }
        //Done .
        public void AddVehicale()
        { // Cheeking (Is Login (password)
            Vehicle vehicle=new Vehicle();
            vehicle.NewVehicle(this);
            vehicles.Add(vehicle);
            Console.WriteLine("Vehicle added successfully!");
            Console.WriteLine("------------------------");
        }
        //Done .
        public void SetActiveVehicle() 
        {
            Console.WriteLine("The list of your vehicles...");
            Console.WriteLine("# Select With index .");
            for (int i = 0;i<vehicles.Count;i++)
            {
                Console.WriteLine($"Type : {vehicles[i].VehicleType} ");
                Console.WriteLine($"License plate :{vehicles[i].LicensePlate}");
                Console.WriteLine($">>Index :{i}");
            }
            Console.WriteLine("-----------");

            string value =Console.ReadLine();
            int index;
            if(int.TryParse(value,out index) && index<vehicles.Count&&index>=0)
            {
                vehicles[index].IsAvailable = true;
                AvailableVehicle = vehicles[index] ;
                Console.WriteLine($"The Vehicle active :{vehicles[index].VehicleType} ,{vehicles[index].LicensePlate}  ");
                Console.WriteLine("------------------------");
                for (int i = 0; i < vehicles.Count ; i++)
                {
                    if(i!=index)  vehicles[i].IsAvailable = false;
                }
                Console.WriteLine($"Vehicle set as active :{vehicles[index].VehicleType} ({vehicles[index].LicensePlate})");
            }
            else
            {
                Console.WriteLine("Invalid input, Please enter a valid input .");
            }
        }
        //Done . 
        public void GetVehicleList ()
        {
            if (!vehicles.Any())
            {
             Console.WriteLine("The list of vehicles is empty");
                return;
            }
            for (int i = 0; i < vehicles.Count; i++)
            {
                Console.WriteLine($">>Index :{i}");
                vehicles[i].GetVehicleInfo();
            }
        }
        //Done . 
        public void WithdrawBalance() 
       {
            if (DriverWallet.Balance > 0)
            {
                decimal withdraw = 0;
                Console.WriteLine($"Balance in wallet : {DriverWallet.Balance}");
                Console.WriteLine("Enter the withdraw amount :");
                string input = Console.ReadLine();
                if(decimal.TryParse(input,out withdraw) && withdraw<= DriverWallet.Balance && withdraw>0)
                    {
                        decimal balance= DriverWallet.WithdrawBalance(withdraw);
                   Console.WriteLine($"Done Withdraw\n The wallet balance :{balance}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid decimal number , less than wallet balance and greater than 0 .");
                }
                
            }
            else { Console.WriteLine("No money to withdraw."); }
       }
        //Done .
        public void Getinformation() 
        {
            Console.WriteLine(Information);
        }
        //Done .
        public void ViewGetBalance() 
        {
            DriverWallet.ViewInfo();
        }
        //Done .
        public void ViewFeedback()

        {
            if (!Feedbacks.Any())
            {
              Console.WriteLine("Feedback list is empty. ");
                return;
            }
          
            
            Console.WriteLine($"The count feedbacks is {Feedbacks.Count} ");
            Console.WriteLine("__________________________________");
            Feedbacks.ForEach(f => f.GetFeedbackDetails());
               
        }
        public void viewRating() { }
        //Done .
        public void ViewRideHistory()
        {
                if(!RideHistory.Any())
                {
                    Console.WriteLine("Ride list is empty. ");
                    return ;

                }
            
                Console.WriteLine("The list of history ride :");
                RideHistory.ForEach(r => r.GetRideDetails());
              
        }

    }
}
