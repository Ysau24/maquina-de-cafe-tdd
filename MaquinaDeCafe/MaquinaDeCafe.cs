namespace MaquinaDeCafe
{
    public class MaquinaDeCafe
    {
        // Campos privados
        private Cafetera cafetera;
        private Vaso vasosPequeno;
        private Vaso vasosMediano;
        private Vaso vasosGrande;
        private Azucarero azucarero;

        // Propiedades públicas (algunos tests usan la propiedad directamente)
        public Vaso VasosPequeno { get { return vasosPequeno; } private set { vasosPequeno = value; } }
        public Vaso VasosMediano { get { return vasosMediano; } private set { vasosMediano = value; } }
        public Vaso VasosGrande { get { return vasosGrande; } private set { vasosGrande = value; } }

        // Métodos "Set" que usa tu test
        public void SetCafetera(Cafetera c) { cafetera = c; }
        public void SetVasosPequeno(Vaso v) { VasosPequeno = v; }
        public void SetVasosMediano(Vaso v) { VasosMediano = v; }
        public void SetVasosGrande(Vaso v) { VasosGrande = v; }
        public void SetAzucarero(Azucarero a) { azucarero = a; }

        // Métodos "Get" que usa tu test
        public Cafetera GetCafetera() { return cafetera; }
        public Vaso GetVasosPequeno() { return vasosPequeno; }
        public Vaso GetVasosMediano() { return vasosMediano; }
        public Vaso GetVasosGrande() { return vasosGrande; }
        public Azucarero GetAzucarero() { return azucarero; }

        // Devuelve la referencia al tipo de vaso según string
        public Vaso GetTipoDeVaso(string tipo)
        {
            if (tipo == null) return null;
            switch (tipo.ToLower())
            {
                case "pequeno": return vasosPequeno;
                case "mediano": return vasosMediano;
                case "grande": return vasosGrande;
                default: return null;
            }
        }

        // Método principal que prepara el vaso de café (retorna mensajes de error o éxito)
        public string GetVasoDeCafe(Vaso vaso, int cantidadVasos, int cantidadAzucar)
        {
            if (vaso == null) return "No hay Vasos";
            // ¿Hay suficientes vasos?
            if (!vaso.HasVasos(cantidadVasos)) return "No hay Vasos";

            // ¿Hay suficiente café? (uso de contenido por vaso * cantidadVasos)
            int totalCafeNecesario = vaso.GetContenido() * cantidadVasos;
            if (cafetera == null || !cafetera.HasCafe(totalCafeNecesario)) return "No hay Cafe";

            // ¿Hay suficiente azúcar?
            if (azucarero == null || !azucarero.HasAzucar(cantidadAzucar)) return "No hay Azucar";

            // Todo OK: descontar recursos
            vaso.GiveVasos(cantidadVasos);
            cafetera.GiveCafe(totalCafeNecesario);
            azucarero.GiveAzucar(cantidadAzucar);

            return "Aquí tiene su café :)";
        }
    }
}
