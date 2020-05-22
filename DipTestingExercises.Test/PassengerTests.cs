using NUnit.Framework;
namespace DipTestingExercises.Test
{
    public class FakePassenger : Passenger
    {
        public FakePassenger(string pFname, string pLname, string pGender, string pTicketType) : base(pFname, pLname, pGender, pTicketType)
        {
           
        }
        
    }

    [TestFixture]
    public class PassengerTests
    {
        FakePassenger passenger;
        [SetUp]
        public void SetUp()
        {
            this.passenger = new FakePassenger("Bob", "Jane", "Male", "Concession Myki");
        }

        [Test]
        public void Constructor_MethodIsCalled_ReturnRightResults()
        {
            Assert.AreEqual(passenger.fname, "Bob");
            Assert.AreEqual(passenger.lname, "Jane");
            Assert.AreEqual(passenger.getGender(), "Male");
        }
        [Test]
        public void getTicketType_IsCalled_ReturnConcessionMyki()
        {
            Assert.AreEqual("Concession Myki", passenger.getTicketType());
        }
    }
}
