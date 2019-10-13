namespace RentCar.Models
{
    public enum ENUM_ESTADO_EMPLEADO
    {
        ACTIVO = 1,
        INACTIVO 
    }
    public class EstadoEmpleado
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public override string ToString()
        {
            return this.Nombre;
        }
    }
}