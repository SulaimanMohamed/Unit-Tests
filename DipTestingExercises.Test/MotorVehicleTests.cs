using NUnit.Framework;
namespace DipTestingExercises.Test
{
    public class FakeMotorVehicle : MotorVehicle
    {
        
        public FakeMotorVehicle(IPerson pDriver, int pMax, int pCurrent, int pLitresPerKM): base(pDriver, pMax,pCurrent, pLitresPerKM)
        {
           
        }
    }
    [TestFixture]
    public class MotorVehicleTests

    {
        FakeMotorVehicle moterVehicle;
        [SetUp]
        public void SetUp()
        {
            this.moterVehicle = new FakeMotorVehicle(null, 100, 50, 2); 


        }
       
        [Test]
        public void Refuel_AppropriateFuelAdded_AddsFuel()
        {
            moterVehicle.refuel(50);
            Assert.AreEqual(100, moterVehicle.currentFuel);

        }
        [Test]
        public void Refuel_TooMuchFuelAdded_RaisesException()
        {
           
            moterVehicle.refuel(51);
            Assert.AreEqual(100, moterVehicle.currentFuel);

        }

        [Test]
        public void Refuel_NegativeFuelAdded_RaisesException()
        {
            moterVehicle.refuel(-1);
            Assert.AreEqual(100, moterVehicle.currentFuel);
        }

        [Test]
        public void Travel_HasEnoughFuel_AdjustCurrentFuel()
        {
            moterVehicle.travel(10);
            Assert.AreEqual(30, moterVehicle.currentFuel);
        }

        [Test]
        public void Travel_RunsOutOfFuel_RaisesExceptionOutOfFuel()
        {
            moterVehicle.travel(26);
            Assert.AreEqual(30, moterVehicle.currentFuel);
        }
    }
}
