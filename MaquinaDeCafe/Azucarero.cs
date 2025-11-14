namespace MaquinaDeCafe
{
    public class Azucarero
    {
        private int cantidadDeAzucar; // unidades de cucharadas

        public Azucarero(int cantidadDeAzucar)
        {
            this.cantidadDeAzucar = cantidadDeAzucar;
        }

        public bool HasAzucar(int cantidad)
        {
            return cantidadDeAzucar >= cantidad;
        }

        public void GiveAzucar(int cantidad)
        {
            cantidadDeAzucar -= cantidad;
        }

        public int GetCantidadAzucar()
        {
            return cantidadDeAzucar;
        }
    }
}
