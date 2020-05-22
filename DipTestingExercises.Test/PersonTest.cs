using NUnit.Framework;

namespace DipTestingExercises.Tests
{
    public class FakePerson : Person
    {
        public FakePerson(string pFname, string pLname, string pGender) : base(pFname, pLname, pGender)
        {
            
        }
       
    }

    public class PersonTest
    {
        FakePerson person;
        [SetUp]
        public void Setup()
        {
            this.person = new FakePerson("Sulaiman", "Mohamed", "Male");
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.AreEqual(this.person.fname, "Sulaiman");
            Assert.AreEqual(this.person.lname, "Mohamed");
            Assert.AreEqual(person.getGender(), "Male");
        }

        [Test]
        public void GetName_MethodIsCalled_ReturnsCorrectGender()
        {
            Assert.AreEqual("Sulaiman Mohamed", person.getName());
        }

        [Test]
        public void GetGender_MethodIsCalled_ReturnsCorrectName()
        {
            Assert.AreEqual("Male", person.getGender());
        }
    }
}