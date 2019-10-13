using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Models
{
    public class Inspeccion
    {
        [Key]
        public int ID { get; set; }
        public int VehiculoID { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
        public int ClienteID { get; set; }
        public virtual Cliente Cliente { get; set; }
        public bool TieneRalladuras { get; set; }
        public int CantidadCombustibleID { get; set; }
        public virtual CantidadCombustible CantidadCombustible { get; set; }
        public bool TieneGomaRepuesta { get; set; }
        public bool TieneGato { get; set; }
        public bool TieneRoturasCristal { get; set; }
        public bool EstadoGoma1 { get; set; }
        public bool EstadoGoma2 { get; set; }
        public bool EstadoGoma3 { get; set; }
        public bool EstadoGoma4 { get; set; }
        public DateTime Fecha { get; set; }
        public int EmpleadoResponsableID { get; set; }
        public virtual Empleado EmpleadoResponsable { get; set; }
        public int EstadoID { get; set; }
        public virtual EstadoInspeccion Estado { get; set; }
        public virtual ICollection<Renta_Devolucion> Rentas_Devolucions { get; set; }
    }
}
