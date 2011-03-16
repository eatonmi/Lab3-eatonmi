using System;
using Expedia;
using NUnit.Framework;

namespace ExpediaTest
{
	[TestFixture()]
	public class FlightTest
	{
        [Test()]
        public void TestThatFlightInitializes()
        {
            var target = new Flight(new DateTime(2010, 12, 24), new DateTime(2010, 12, 29), 1000);
            Assert.IsNotNull(target);
        }
        [Test()]
        public void TestThatFlightGetsMiles()
        {
            var target = new Flight(new DateTime(2010, 12, 24), new DateTime(2010, 12, 29), 1000);
            Assert.IsNotNull(target.Miles);
        }
        [Test()]
        public void TestThatFlightGetsRightMiles()
        {
            var target = new Flight(new DateTime(2010, 12, 24), new DateTime(2010, 12, 29), 1000);
            Assert.AreEqual(1000, target.Miles);
        }
        [Test()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestThatDatesCannotBeImproper()
        {
            var target = new Flight(new DateTime(2010, 12, 31), new DateTime(2010, 12, 29), 1000);
        }
        [Test()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestThatMilesCannotBeLessThanZero()
        {
            var target = new Flight(new DateTime(2010, 12, 24), new DateTime(2010, 12, 29), -1);
        }
        [Test()]
        public void TestEquals()
        {
            var target1 = new Flight(new DateTime(2010, 12, 24), new DateTime(2010, 12, 29), 1000);
            var target2 = new Flight(new DateTime(2010, 12, 24), new DateTime(2010, 12, 29), 1000);
            Assert.AreEqual(target1, target2);
        }
	}
}
