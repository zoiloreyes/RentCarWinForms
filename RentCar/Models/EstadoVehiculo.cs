using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Models
{
    public enum ENUM_ESTADO_VEHICULO
    {
        DISPONIBLE = 1,
        RENTADO = 2,
        NO_DISPONIBLE = 3
    }
    public class EstadoVehiculo
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
