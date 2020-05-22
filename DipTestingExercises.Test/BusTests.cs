using NUnit.Framework;

namespace DipTestingExercises.Test
{
   
    public class FakeBus : Bus
    {

        

        public FakeBus(IPerson pDriver, int pMaxFuel, int pCurrent, int pLitresPerKM, int pMaxPassengers) : base(pDriver, pMaxFuel, pCurrent, pLitresPerKM, pMaxPassengers)
        {
            
        }

       

    }
   
    [TestFixture]
    public class BusTests
    {
        FakeBus bus;
        FakeDriver driver;
        FakePassenger passenger;
        
        [SetUp]
        public void SetUp()
        {
            this.bus = new FakeBus(driver, 100, 50, 2, 1);
            
            
        }
       
        [Test]
        public void Constructor_BusMaxPassenger_ReturnsCorrectNumber()
        {
            Assert.AreEqual(1, bus.maxPassengers);
        }

        [Test]
        public void GetPassengerCount_BusIsEmpty_ReturnsZero()
        {
            Assert.AreEqual(0, bus.getPassengerCount());
            
        }

        [Test]
        public void GetPassengerCount_BusHasPassenger_ReturnsOne()
        {
            bus.passengers.Add(passenger);
            Assert.AreEqual(1, bus.getPassengerCount());
        }

        [Test]
        public void EmbarkPassenger_BusHasSpace_PassengerAddedToList()
        {
            bus.embarkPassenger(passenger);
            Assert.AreEqual(1, bus.getPassengerCount());
        }
        
        [Test]
        public void EmbarkPassenger_BusIsFull_BusIsFullException()
        {
            bus.embarkPassenger(passenger);
            bus.embarkPassenger(passenger);
            bus.embarkPassenger(passenger);
            Assert.AreEqual(3, bus.getPassengerCount());
        }

        [Test]
        [Ignore("Ignore a test.")]
        public void Test_To_Ignore()
        {

        }
    }
}
