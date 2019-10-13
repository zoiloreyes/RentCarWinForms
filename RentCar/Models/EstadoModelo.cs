using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Models
{
    public enum ENUM_ESTADO_MODELO
    {
        ACTIVO = 1,
        INACTIVO    
    }
    public class EstadoModelo
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
