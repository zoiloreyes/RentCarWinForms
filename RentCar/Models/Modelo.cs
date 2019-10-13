using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Models
{
    public class Modelo
    {
        public int ID { get; set; }
        public int MarcaID { get; set; }
        public virtual Marca Marca { get; set; }
        public string Descripcion { get; set; }
        public int EstadoID { get; set; }
        public virtual EstadoModelo Estado { get; set; }

        public override string ToString()
        {
            return $"{Descripcion}";
        }

    }
}
