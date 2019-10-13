using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Models
{
    public class TipoCombustible
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public int EstadoID { get; set; }
        public virtual EstadoTipoCombustible Estado { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
