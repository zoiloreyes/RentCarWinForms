using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Models
{
    public enum ENUM_ESTADO_CLIENTE
    {
        ACTIVO = 1,
        INACTIVO
    }
    public class EstadoCliente
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
