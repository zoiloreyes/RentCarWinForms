namespace RentCar.Models
{
    public class TandaLaboral
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return $"{Nombre}";
        }
    }
}