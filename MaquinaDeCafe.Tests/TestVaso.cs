using NUnit.Framework;

namespace MaquinaDeCafe.Tests
{
    [TestFixture]
    public class TestVaso
    {
        [Test]
        public void DeberiaDevolverVerdaderoSiExistenVasos()
        {
            var vasosPequenos = new Vaso(2, 10);
            bool resultado = vasosPequenos.HasVasos(1);
            Assert.That(resultado, Is.True);
        }

        [Test]
        public void DeberiaDevolverFalsoSiNoExistenVasos()
        {
            var vasosPequenos = new Vaso(1, 10);
            bool resultado = vasosPequenos.HasVasos(2);
            Assert.That(resultado, Is.False);
        }

        [Test]
        public void DeberiaRestarCantidadDeVaso()
        {
            var vasosPequenos = new Vaso(5, 10);
            vasosPequenos.GiveVasos(1);
            Assert.That(vasosPequenos.GetCantidadVasos(), Is.EqualTo(4));
        }
    }
}
