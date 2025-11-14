namespace MaquinaDeCafe
{
    public class Vaso
    {
        private int cantidadVasos;
        private int contenido; // onzas de café que contiene el vaso

        public Vaso(int cantidadVasos, int contenido)
        {
            this.cantidadVasos = cantidadVasos;
            this.contenido = contenido;
        }

        public bool HasVasos(int cantidad)
        {
            return cantidadVasos >= cantidad;
        }

        public void GiveVasos(int cantidad)
        {
            cantidadVasos -= cantidad;
        }

        public int GetCantidadVasos()
        {
            return cantidadVasos;
        }

        public int GetContenido()
        {
            return contenido;
        }
    }
}
