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
        public List<Ride> RideHistory { get; set; }
        public Wallet PassangerWallt { get; set; } =new Wallet();
        public Location CurrentLocation { get; set; }
        public string Rating {  get; set; } 


    }
}
