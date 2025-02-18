using System;
using System.Globalization;
namespace Ride_Sharing_App  
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            string m = "Mina ";
            var f1 = new Feedback(m);
            var f2 = new Feedback(m);
            var f3 = new Feedback(m);
            var f4 = new Feedback(m);
            var r1 = new Ride();
            var r2 = new Ride();
            var r3 = new Ride();
            var r4 = new Ride();
            var driver1 = new Driver("this is information","Mina","3000499","Eamil@gmail.com","01277071307");
            var p1 = new Passenger();
            driver1.Feedbacks.Add(f1);
            driver1.Feedbacks.Add(f2);
            driver1.Feedbacks.Add(f3);
            driver1.Feedbacks.Add(f4);
            driver1.RideHistory.Add(r1);
            driver1.RideHistory.Add(r2);
            driver1.RideHistory.Add(r3);
            driver1.RideHistory.Add(r4);
            //driver1.ViewFeedback();
            Console.ReadLine();

        }
    }  
} 
