using RentCar.DAL;
using RentCar.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;

namespace RentCar.Forms.Empleados
{
    public partial class SelectorEmpleado : Form
    {
        private RentCarContext dbContext;
        public event EventHandler<EmpleadoSeleccionadoEventArgs> OnEmpleadoSeleccionado;
        public SelectorEmpleado()
        {
            dbContext = RentCarContext.Create();
            InitializeComponent();
            Display();
        }

        private void Display()
        {
            dgEmpleados.DataSource = dbContext.Empleados.Include(e => e.TandaLaboral).AsNoTracking().Where(e => e.EstadoID == ((int)ENUM_ESTADO_EMPLEADO.ACTIVO))
                .ToList()
                .Select(e => new
                {
                    Identificador = e.ID,
                    Nombre = $"{e.Nombre} {e.Apellido}",
                    Cedula = e.Cedula,
                    TandaLaboral = e.TandaLaboral.Nombre,
                    e.FechaIngreso
                }).ToList();
        }

        private void DgEmpleados_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var idEmpleado = int.Parse(dgEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString());

            var empleado = dbContext.Empleados
                                    .Include(emp => emp.Usuario)
                                    .Include(emp => emp.TandaLaboral)
                                    .Include(emp => emp.Estado)
                                    .AsNoTracking().FirstOrDefault(emp => emp.ID == idEmpleado);

            this.OnEmpleadoSeleccionado(this, new EmpleadoSeleccionadoEventArgs() { Empleado = empleado });
            this.Close();
        }

        private void DgEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }

    public class EmpleadoSeleccionadoEventArgs: EventArgs
    {
        public Empleado Empleado { get; set; }
    }
}
