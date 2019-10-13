namespace RentCar.Models
{
    public class CantidadCombustible
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return $"{Nombre}";
        }
    }
}