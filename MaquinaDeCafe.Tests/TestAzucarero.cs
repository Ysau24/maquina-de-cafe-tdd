using NUnit.Framework;

namespace MaquinaDeCafe.Tests
{
    [TestFixture]
    public class TestAzucarero
    {
        private Azucarero azucarero;

        [SetUp]
        public void SetUp()
        {
            azucarero = new Azucarero(10);
        }

        [Test]
        public void DeberiaDevolverVerdaderoSiHaySuficienteAzucar()
        {
            bool resultado = azucarero.HasAzucar(5);
            Assert.That(resultado, Is.True);

            resultado = azucarero.HasAzucar(10);
            Assert.That(resultado, Is.True);
        }

        [Test]
        public void DeberiaDevolverFalsoSiNoHaySuficienteAzucar()
        {
            bool resultado = azucarero.HasAzucar(15);
            Assert.That(resultado, Is.False);
        }

        [Test]
        public void DeberiaRestarAzucarCorrectamente()
        {
            azucarero.GiveAzucar(5);
            Assert.That(azucarero.GetCantidadAzucar(), Is.EqualTo(5));

            azucarero.GiveAzucar(2);
            Assert.That(azucarero.GetCantidadAzucar(), Is.EqualTo(3));
        }
    }
}
