using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using RentCar.DAL;
using RentCar.Extensions;
using RentCar.Helpers;
using RentCar.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar.Forms.Empleados
{
    public partial class NuevoEmpleado : Form
    {
        private RentCarContext dbContext;
        private UserManager<Usuario> manager;
        public event EventHandler<NuevoEmpleadoEventArgs> OnNuevoClienteAdded;
        public NuevoEmpleado()
        {
            dbContext = RentCarContext.Create();
            manager = new UserManager<Usuario>(new UserStore<Usuario>(dbContext));
            InitializeComponent();
            CargarTandas();
        }

        private void CargarTandas()
        {
            cboTanda.Items.AddRange(dbContext.TandasLaborales.ToArray());
        }

        public bool Validar()
        {
            if (String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre de empleado");
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Ingrese un apellido de empleado");
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show("Ingrese una cédula");
                return false;
            }
            if (!txtCedula.Text.CedulaValida()) 
            {
                MessageBox.Show("Cédula no válida");
                return false;
            }

            if (cboTanda.SelectedItem == null)
            {
                MessageBox.Show("Ingrese una tanda laboral");
                return false;
            }

            return true;
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }

            var empleado = new Empleado()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Cedula = txtCedula.Text,
                TandaLaboralID = ((TandaLaboral)cboTanda.SelectedItem).ID,
                EstadoID = (int)ENUM_ESTADO_EMPLEADO.ACTIVO,
                FechaIngreso = dpFechaIngreso.Value,
                PorcComision = (nudComision.Value / 100)
            };

            dbContext.Empleados.Add(empleado);

            var username = empleado.GenerateUserName();
            var usuarios = dbContext.Users.Where(u => u.UserName.Contains(username)).ToList();
            username += usuarios.Count > 0 ? (usuarios.Count + 1).ToString() : "";

            
            try
            {
                var usuario = new Usuario()
                {
                    UserName = username,
                    Email = "",
                    EmailConfirmed = true,
                    Nombre = empleado.Nombre,
                    Apellido = empleado.Apellido
                };
                manager.Create(usuario, "contrasena");
                empleado.UsuarioID = usuario.Id;
            }
            catch (DbEntityValidationException ev)
            {
                foreach (var eve in ev.EntityValidationErrors)
                {
                    MessageBox.Show($"Entity of type {eve.Entry.Entity.GetType().Name} in state {eve.Entry.State} has the following validation errors:");
                    foreach (var ve in eve.ValidationErrors)
                    {
                        MessageBox.Show($"- Property: {ve.PropertyName}, Error: {ve.ErrorMessage}");
                    }
                }
                throw;
            }

            dbContext.SaveChanges();
            this.OnNuevoClienteAdded(this, new NuevoEmpleadoEventArgs() { Empleado = empleado });
            this.Close();

        }
    }

    public class NuevoEmpleadoEventArgs : EventArgs {
          public Empleado Empleado { get; set; }
    }
}
