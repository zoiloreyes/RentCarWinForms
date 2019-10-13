using RentCar.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using RentCar.Models;

namespace RentCar.Forms.Empleados
{
    public partial class DetalleEmpleado : Form
    {
        private RentCarContext dbContext;
        public event EventHandler<EditarEmpleadoEventArgs> OnEmpleadoActualizado;
        public event EventHandler<EliminarEmpleadoEventArgs> OnEmpleadoEliminado;
        public Empleado Empleado;
        public DetalleEmpleado(int EmpleadoID)
        {
            dbContext = RentCarContext.Create();
            InitializeComponent();
            CargarEmpleado(EmpleadoID);
        }

        private void CargarEmpleado(int empleadoID)
        {
            var empleado = dbContext.Empleados
                            .Include(e => e.TandaLaboral)
                            .AsNoTracking()
                            .FirstOrDefault(e => e.ID == empleadoID);

            this.Empleado = empleado;
            lblTitulo.Text = $"{Empleado.ID} - {Empleado.Nombre} {Empleado.Apellido}";
            lblIdentificador.Text = Empleado.ID.ToString();
            lblNombre.Text = Empleado.Nombre;
            lblApellido.Text = Empleado.Apellido;
            lblTandaLaboral.Text = Empleado.TandaLaboral.Nombre;
            lblCedula.Text = Empleado.Cedula;
            lblFechaIngreso.Text = Empleado.FechaIngreso.ToString("dd/MM/yyyy");
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var editarForm = new EditarEmpleado(Empleado.ID);
            editarForm.OnEmpleadoActualizado += (s, ev) =>
            {

                MessageBox.Show("Empleado Actualizado");
                this.OnEmpleadoActualizado(this, new EditarEmpleadoEventArgs() { Empleado = ev.Empleado });
                this.CargarEmpleado(ev.Empleado.ID);
            };
            editarForm.Show();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            var aRemover = dbContext.Empleados.Find(Empleado.ID);
            aRemover.EstadoID = (int)ENUM_ESTADO_EMPLEADO.INACTIVO;
            dbContext.SaveChanges();
            OnEmpleadoEliminado(this, new EliminarEmpleadoEventArgs() { Empleado = aRemover });
            this.Close();
        }

        private void DetalleEmpleado_Load(object sender, EventArgs e)
        {

        }
    }

    public class EliminarEmpleadoEventArgs : EventArgs
    {
        public Empleado Empleado { get; set; }
    }
}
