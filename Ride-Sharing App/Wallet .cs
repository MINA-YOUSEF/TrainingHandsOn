using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Sharing_App
{
    internal class Wallet
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public decimal Balance { get; private set; } = 1000;
        
      
    public void ViewInfo()
        {
            Console.WriteLine($"The wallet id: {Id}");
            Console.WriteLine($"The user id: {UserId}");
            Console.WriteLine($"The wallet Balance: {Balance}");
        }
     public decimal WithdrawBalance (decimal balance)
        {
            if(balance<=Balance && balance > 0)
            {
                Balance -= balance;
            }
            else
            {
                return 0;
            }
            return Balance;
        }
     public decimal AddBalance (decimal balance) { 
            Balance += balance;

        return Balance;
        }


    }
}
