namespace RentCar.Models
{
    public enum ENUM_ESTADO_INSPECCION
    {
        VALIDA = 1,
        INVALIDA = 2
    }
    public class EstadoInspeccion
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public override string ToString()
        {
            return this.Nombre;
        }
    }
}