using RentCar.DAL;
using RentCar.Extensions;
using RentCar.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar.Forms.Empleados
{
    public partial class EditarEmpleado : Form
    {
        private RentCarContext dbContext;
        public event EventHandler<EditarEmpleadoEventArgs> OnEmpleadoActualizado;

        public EditarEmpleado(int EmpleadoID)
        {
            dbContext = RentCarContext.Create();
            InitializeComponent();
            CargarTandas();
            CargarEmpleado(EmpleadoID);
        }

        public void CargarEmpleado(int empleadoID)
        {
            var Empleado = dbContext.Empleados.Find(empleadoID);


            if (Empleado == null)
                return;

            lblTitulo.Text = $"{Empleado.ID.ToString()} {Empleado.Nombre} {Empleado.Apellido}";
            txtCedula.Text = Empleado.Cedula;
            txtNombre.Text = Empleado.Nombre;
            txtApellido.Text = Empleado.Apellido;
            txtIdentificador.Text = Empleado.ID.ToString();
            cboTanda.SelectedItem = Empleado.TandaLaboral;
            nudComision.Value = Empleado.PorcComision;
            dpFechaIngreso.Value = Empleado.FechaIngreso;
        }

        public bool Validar()
        {
            if (String.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show("Ingresa una cédula");
                return false;
            }
            if (!txtCedula.Text.CedulaValida())
            {
                MessageBox.Show("Cédula no válida");
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingresa un nombre");
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Ingresa un apellido");
                return false;
            }

            if(cboTanda.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una tanda");
                return false;
            }

            return true;

        }

        private void CargarTandas()
        {
            cboTanda.Items.AddRange(dbContext.TandasLaborales.ToArray());
        }

        private void EditarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void TxtIdentificador_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (!Validar()) {
                return;
            }

            var empleado = dbContext.Empleados.Find(int.Parse(txtIdentificador.Text));
            var usuario = dbContext.Users.Find(empleado.UsuarioID);

            usuario.Nombre = txtNombre.Text;
            usuario.Apellido = txtApellido.Text;
            empleado.Nombre = txtNombre.Text;
            empleado.Apellido = txtApellido.Text;
            empleado.Cedula = txtCedula.Text;
            empleado.TandaLaboralID = ((TandaLaboral)cboTanda.SelectedItem).ID;
            empleado.FechaIngreso = dpFechaIngreso.Value;

            dbContext.SaveChanges();
            OnEmpleadoActualizado(this, new EditarEmpleadoEventArgs() { Empleado = empleado });
            this.Close();
        }
    }

    public class EditarEmpleadoEventArgs: EventArgs
    {
        public Empleado Empleado { get; set; }
    }
}
