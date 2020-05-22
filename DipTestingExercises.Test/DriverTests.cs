using NUnit.Framework;

namespace DipTestingExercises.Test
{
    public class FakeDriver : Driver
    {
        public FakeDriver(string pFname, string pLname, string pGender, string pLicence) : base(pFname, pLname, pGender, pLicence)
        {
            
        }
    }

    [TestFixture]
    public class DriverTests
    {
        FakeDriver driver;
        [SetUp]
        public void SetUp()
        {
            this.driver = new FakeDriver("Sulaiman", "Mohamed", "Male", "PCV");
        }
        [Test]
        public void Constructor_MethodIsCalled_CorrectValueReturned()
        {
            Assert.AreEqual("Sulaiman Mohamed",driver.getName());
            Assert.AreEqual("Male", driver.getGender());
            Assert.AreEqual("PCV", driver.getLicenceType());
        }

        [Test]
        public void GetLicenceType_MethodIsCalled_ReturnsLicenceType()
        {
            Assert.AreEqual("PCV", driver.getLicenceType());
        }
       
    }
}
