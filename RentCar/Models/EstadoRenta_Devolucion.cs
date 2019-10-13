namespace RentCar.Models
{
    public enum ENUM_ESTAD_RENTA_DEVOLUCION {
        VALIDA = 1,
        INVALIDA 
    }

    public class EstadoRenta_Devolucion
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public override string ToString()
        {
            return this.Nombre;
        }
    }
}