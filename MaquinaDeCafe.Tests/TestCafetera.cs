using NUnit.Framework;

namespace MaquinaDeCafe.Tests
{
    [TestFixture]
    public class TestCafetera
    {
        [Test]
        public void DeberiaDevolverVerdaderoSiExisteCafe()
        {
            var cafetera = new Cafetera(10);
            bool resultado = cafetera.HasCafe(5);
            Assert.That(resultado, Is.True);
        }

        [Test]
        public void DeberiaDevolverFalsoSiNoExisteCafe()
        {
            var cafetera = new Cafetera(10);
            bool resultado = cafetera.HasCafe(11);
            Assert.That(resultado, Is.False);
        }

        [Test]
        public void DeberiaRestarCafeALaCafetera()
        {
            var cafetera = new Cafetera(10);
            cafetera.GiveCafe(7);
            Assert.That(cafetera.GetCantidadCafe(), Is.EqualTo(3));
        }
    }
}
