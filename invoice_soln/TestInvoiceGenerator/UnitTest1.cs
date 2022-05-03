using Cab_Invoice_Generator_Problem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cab_Invoice_Generator_Problem
{
    
    public class UnitTest1
    {
        //InvoiceGenerator reference
        InvoiceGenerator InvoiceGenerator = null;

        [TestMethod]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            //creating object for InvoiceGenerator For Normal Ride
            InvoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 5.0;
            int time = 5;

            //calculating fare
            double fare = InvoiceGenerator.CalculateFare(distance, time);
            double expected = 55;

            //asserting values
            Assert.AreEqual(expected, fare);
        }


        //testing method for multiple Rides...................
        [TestMethod]
        public void GivenMultipleRidesShouldReturnsAggregateTotalFare()
        {
            //creating object for normal type ride using invoiceGenerator...........
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(3, 25), new Ride(5, 10) };
            double expected = 70;
            //Act
            double actual = invoiceGenerator.CalulateFare(rides);
            //Assert
            Assert.AreEqual(expected, actual);
        }


        // testing method of Average calculating.....................
        [TestMethod]
        public void GivenMultipleRidesShouldReturnsAggregateTotalFareWithAverage()
        {
            //Arrange(creating object for invoiceGenerator of normal ride)
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(3, 25), new Ride(5, 10) };
            InvoiceSummary expected = new InvoiceSummary(70, rides.Length);

            //Act
            InvoiceSummary actual = invoiceGenerator.CalulateFare(rides);
            //Assert
            Assert.AreEqual(expected, actual);
            //expected.Equals(actual);
        }

    }
}