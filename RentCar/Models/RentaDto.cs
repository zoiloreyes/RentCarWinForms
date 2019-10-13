using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Models
{
    public class RentaDto
    {
        public string Cliente { get; set; }
        public string Marca { get; set; }
        public string Empleado { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string TipoVehiculo { get; set; }
        public string FechaRenta { get; set; }
        public string FechaDevolucion { get; set; }
        public decimal Valor { get; set; }
    }
}
