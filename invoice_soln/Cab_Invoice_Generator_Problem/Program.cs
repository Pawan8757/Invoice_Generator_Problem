using System;
namespace Cab_Invoice_Generator_Problem
{
    class program
    {
        public static void Main(string[] args)
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            //double fare= invoiceGenerator.CalculateFare(2.0, 6);
            Ride[] rides = { new Ride(3, 25), new Ride(5, 10) };
          
            Console.ReadLine();
            // Console.WriteLine(fare);
            Console.WriteLine(rides);
        }
    }
}