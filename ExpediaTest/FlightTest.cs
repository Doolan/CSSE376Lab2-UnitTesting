using System;
using Expedia;
using NUnit.Framework;

namespace ExpediaTest
{
	[TestFixture()]
	public class FlightTest
	{
		//TODO Task 7 items go here
        private readonly DateTime startDate = DateTime.Today;
        private readonly DateTime endDate = DateTime.Today.AddDays(5.4);
        private readonly int mileCount = 5;

        [Test()]
        public void TestThatFlightInitializes()
        {
            var target = new Flight(startDate, endDate, mileCount);
            Assert.IsNotNull(target);
        }

        [Test()]
        public void TestThatFlightHasCorrectBasePriceForOneDay()
        {
            var target = new Flight(startDate, startDate.AddDays(1), mileCount);
            Assert.AreEqual(220, target.getBasePrice());
        }

        [Test()]
        public void TestThatFlightHasCorrectBasePriceForTwoDays()
        {
            var target = new Flight(startDate, startDate.AddDays(2), mileCount);
            Assert.AreEqual(240, target.getBasePrice());
        }
        [
        Test()]
        public void TestThatFlightHasCorrectBasePriceForTenDays()
        {
            var target = new Flight(startDate, startDate.AddDays(10), mileCount);
            Assert.AreEqual(400, target.getBasePrice());
        }

        [Test()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestThatFlightThrowsOnBadDates()
        {
            var target = new Flight(endDate, startDate, mileCount);
        }

        [Test()]
        public void TestThatFlightDoesntThrowsOnSameDate()
        {
            var target = new Flight(startDate, startDate, mileCount);
        }

        [Test()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestThatFlightThrowsOnBadLength()
        {
            var target = new Flight(startDate, endDate, -25);
        }
	}
}
