using RentCar.DAL;
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
using RentCar.Models;

namespace RentCar.Forms.Empleados
{
    public partial class EmpleadosMain : Form
    {
        private RentCarContext dbContext;
        public EmpleadosMain()
        {
            dbContext = RentCarContext.Create();
            InitializeComponent();
            Display();
        }

        private void DgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnDetalles_Click(object sender, EventArgs e)
        {
            if (dgEmpleados.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }

            var detalleform = new DetalleEmpleado((int)dgEmpleados.SelectedRows[0].Cells[0].Value);
            detalleform.OnEmpleadoActualizado += (s, ev) =>
            {
                this.Display();
            };

            detalleform.OnEmpleadoEliminado += (s, ev) =>
            {
                this.Display();
            };
            detalleform.Show();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            NuevoEmpleado nuevoFrom = new NuevoEmpleado();
            nuevoFrom.Show();
            nuevoFrom.OnNuevoClienteAdded += (s, ev) =>
            {
                MessageBox.Show($"Nuevo Empleado agregado. Usuario {ev.Empleado.Usuario.UserName}. Contraseña: contrasena");
                this.Display();
            };
        }

        private void Display()
        {
            dgEmpleados.DataSource = dbContext.Empleados.Include(e => e.TandaLaboral).AsNoTracking().Where(e => e.EstadoID == ((int) ENUM_ESTADO_EMPLEADO.ACTIVO))
                .ToList()
                .Where(e => (String.IsNullOrWhiteSpace(txtBuscar.Text) || e.Cedula.ToLower().Contains(txtBuscar.Text.ToLower()))
                            || (String.IsNullOrWhiteSpace(txtBuscar.Text) || e.Nombre.ToLower().Contains(txtBuscar.Text.ToLower()))
                            || (String.IsNullOrWhiteSpace(txtBuscar.Text) || e.ID.ToString().Contains(txtBuscar.Text.ToLower())))
                .Select(e => new
            {
                Identificador = e.ID,
                Nombre = $"{e.Nombre} {e.Apellido}",
                Cedula = e.Cedula,
                TandaLaboral = e.TandaLaboral.Nombre,
                e.FechaIngreso
            }).ToList();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal formMenu = new MenuPrincipal();
            formMenu.Show();
            this.Close();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if(dgEmpleados.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }

            var form = new EditarEmpleado((int)dgEmpleados.SelectedRows[0].Cells[0].Value);
            form.OnEmpleadoActualizado += (s, ev) =>
            {
                MessageBox.Show("Empleado Actualizado");
                this.Display();
            };
            form.Show();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgEmpleados.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }

            var cliente = dbContext.Clientes.Find((int)dgEmpleados.SelectedRows[0].Cells[0].Value);
            cliente.EstadoID = (int)ENUM_ESTADO_CLIENTE.INACTIVO;
            dbContext.SaveChanges();
            this.Display();
        }

        private void EmpleadosMain_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Display();
        }
    }
}
