using NUnit.Framework;

using UnitTestAndDebug;

namespace PersonTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
            Person persona = new Person();
        }

        [Test]
        public void nombreCorrectoTest()
        {
            string nombreCorrecto= "Alejandra"; 
            persona = Person("Alejandra","");
            Assert.AreEqual(nombreCorrecto,persona.Name);           
        }

        [Test]
        public void cICorrectaTest()
        {
            string cICorrecta= "5.028.441-8"; 
            persona = Person("","5028441-8");
            Assert.AreEqual(cICorrecta,prueba.ID);           
        }

        [Test]
        public void nombreIncorrectoTest()
        {
            string nombreIncorrecto= ""; 
            persona = Person("","");
            Assert.AreEqual(null,prueba.Name);           
        }

        [Test]
        public void cIIncorrectaTest()
        {
            string cIIncorrecta= "123123123"; 
            persona = Person("", cIIncorrecta);
            Assert.AreEqual(null,prueba.ID);           
        }

        [Test]
        public void IntroduceYourselfTest() 
        {
            string nombre = "Alejandra";
            string ci = "50284418";
            persona = Person("Alejandra", "5.028.441-8");
            Assert.AreEqual(nombre, persona.Name);
            Assert.AreEqual(ci, persona.Id);
            Assert.AreEqual("Soy Alejandra y mi cédula es 5.028.441-8", persona.IntroduceYourself());
        }
    }
}