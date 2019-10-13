using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Models
{
    public class Renta_Devolucion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public int EmpleadoID { get; set; }
        public virtual Empleado Empleado { get; set; }
        public int VehiculoID { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
        public int ClienteID { get; set; }
        public virtual Cliente Cliente { get; set; }
        [ForeignKey("Inspeccion")]
        public int InspeccionID { get; set; }
        public virtual Inspeccion Inspeccion { get; set; }
        public DateTime FechaRenta { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public decimal MontoXDia { get; set; }
        public int CantidadDias { get; set; }
        public string Comentario { get; set; }
        public int EstadoID { get; set; }
        public virtual EstadoRenta_Devolucion Estado { get; set; }
    }
}
