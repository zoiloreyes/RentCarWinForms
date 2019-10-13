using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Models
{
    public class Vehiculo
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public string NumChasis { get; set; }
        public string NumMotor { get; set; }
        public string NumPlaca { get; set; }
        public int TipoVehiculoID { get; set; }
        public virtual TipoVehiculo TipoVehiculo { get; set; }
        public int MarcaID { get; set; }
        public virtual Marca Marca { get; set; }
        public int ModeloID { get; set; }
        public virtual Modelo Modelo { get; set; }
        public int TipoCombustibleID { get; set; }
        public virtual TipoCombustible TipoCombustible { get; set; }
        public int EstadoID { get; set; }
        public virtual EstadoVehiculo Estado { get; set; }
    }
}
