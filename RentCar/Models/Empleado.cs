using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Models
{
    public class Empleado
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public int TandaLaboralID { get; set; }
        public virtual TandaLaboral TandaLaboral {get;set;}
        public decimal PorcComision { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int EstadoID { get; set; }
        public virtual EstadoEmpleado Estado { get; set; }
        public string UsuarioID { get; set; }
        public virtual Usuario Usuario { get; set; }

        public override string ToString()
        {
            return $"{ID} - {Nombre} {Apellido}";
        }
    }
}
