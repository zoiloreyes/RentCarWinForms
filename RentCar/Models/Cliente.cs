using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string TarjetaCredito { get; set; }
        public decimal LimiteCredito { get; set; }
        public int TipoPersonaID { get; set; }
        public virtual TipoPersona TipoPersona { get; set; }
        public int EstadoID { get; set; }
        public virtual EstadoCliente Estado{ get; set; }
        public string Telefono { get; set; }

        public override string ToString()
        {
            return $"{ID} - {Nombre}";
        }
    }
}
