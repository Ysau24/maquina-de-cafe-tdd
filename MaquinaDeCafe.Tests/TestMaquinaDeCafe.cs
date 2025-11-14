using NUnit.Framework;

namespace MaquinaDeCafe.Tests
{
    [TestFixture]
    public class TestMaquinaDeCafe
    {
        private Cafetera cafetera;
        private Vaso vasosPequeno;
        private Vaso vasosMediano;
        private Vaso vasosGrande;
        private Azucarero azucarero;
        private MaquinaDeCafe maquinaDeCafe;

        [SetUp]
        public void SetUp()
        {
            cafetera = new Cafetera(50);
            vasosPequeno = new Vaso(5, 10);
            vasosMediano = new Vaso(5, 20);
            vasosGrande = new Vaso(5, 30);
            azucarero = new Azucarero(20);

            maquinaDeCafe = new MaquinaDeCafe();
            maquinaDeCafe.SetCafetera(cafetera);
            maquinaDeCafe.SetVasosPequeno(vasosPequeno);
            maquinaDeCafe.SetVasosMediano(vasosMediano);
            maquinaDeCafe.SetVasosGrande(vasosGrande);
            maquinaDeCafe.SetAzucarero(azucarero);
        }

        [Test]
        public void DeberiaDevolverUnVasoPequeno()
        {
            var vaso = maquinaDeCafe.GetTipoDeVaso("pequeno");
            Assert.That(vaso, Is.EqualTo(maquinaDeCafe.VasosPequeno));
        }

        [Test]
        public void DeberiaDevolverUnVasoMediano()
        {
            var vaso = maquinaDeCafe.GetTipoDeVaso("mediano");
            Assert.That(vaso, Is.EqualTo(maquinaDeCafe.VasosMediano));
        }

        [Test]
        public void DeberiaDevolverUnVasoGrande()
        {
            var vaso = maquinaDeCafe.GetTipoDeVaso("grande");
            Assert.That(vaso, Is.EqualTo(maquinaDeCafe.VasosGrande));
        }

        [Test]
        public void DeberiaDevolverNoHayVasos()
        {
            var vaso = maquinaDeCafe.GetTipoDeVaso("pequeno");
            string resultado = maquinaDeCafe.GetVasoDeCafe(vaso, 10, 2);
            Assert.That(resultado, Is.EqualTo("No hay Vasos"));
        }

        [Test]
        public void DeberiaDevolverNoHayCafe()
        {
            cafetera = new Cafetera(5);
            maquinaDeCafe.SetCafetera(cafetera);
            var vaso = maquinaDeCafe.GetTipoDeVaso("pequeno");
            string resultado = maquinaDeCafe.GetVasoDeCafe(vaso, 1, 2);
            Assert.That(resultado, Is.EqualTo("No hay Cafe"));
        }

        [Test]
        public void DeberiaDevolverNoHayAzucar()
        {
            azucarero = new Azucarero(2);
            maquinaDeCafe.SetAzucarero(azucarero);
            var vaso = maquinaDeCafe.GetTipoDeVaso("pequeno");
            string resultado = maquinaDeCafe.GetVasoDeCafe(vaso, 1, 3);
            Assert.That(resultado, Is.EqualTo("No hay Azucar"));
        }

        [Test]
        public void DeberiaRestarCafe()
        {
            var vaso = maquinaDeCafe.GetTipoDeVaso("pequeno");
            maquinaDeCafe.GetVasoDeCafe(vaso, 1, 3);
            int resultado = maquinaDeCafe.GetCafetera().GetCantidadCafe();
            Assert.That(resultado, Is.EqualTo(40));
        }

        [Test]
        public void DeberiaRestarVaso()
        {
            var vaso = maquinaDeCafe.GetTipoDeVaso("pequeno");
            maquinaDeCafe.GetVasoDeCafe(vaso, 1, 3);
            int resultado = maquinaDeCafe.GetVasosPequeno().GetCantidadVasos();
            Assert.That(resultado, Is.EqualTo(4));
        }
    }
}
