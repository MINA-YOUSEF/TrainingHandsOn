using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Sharing_App
{
    internal class Driver :AppUser
    {
        public string Information {  get; set; }
        public List<Ride> RideHistory { get; set; }
        public  Vehicle vehicle { get; set; }
        public Wallet DriverWallet { get; set; } =new Wallet();
        public bool IsActive { get; set; }  
        public string Rating { get; set; }
        public Location CurrentLocation { get; set; }

    }
}
