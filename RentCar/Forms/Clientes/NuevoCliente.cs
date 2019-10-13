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

namespace RentCar.Forms.Clientes
{
    public partial class NuevoCliente : Form
    {
        private RentCarContext dbContext;
        public event EventHandler<NuevoClienteEventArgs> OnNuevoClienteAdded;
        public NuevoCliente()
        {
            dbContext = RentCarContext.Create();
            InitializeComponent();
            CargarEstados();
            CargarTiposPersona();
        }

        private void CargarTiposPersona()
        {
            cboTipoPersona.Items.AddRange(dbContext.TiposPersona.OrderBy(t => t.Nombre).ToArray());
        }

        private void CargarEstados()
        {
            cboEstado.Items.AddRange(dbContext.EstadosCliente.OrderBy(t => t.Nombre).ToArray());
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void NuevoCliente_Load(object sender, EventArgs e)
        {

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

            if (String.IsNullOrWhiteSpace(txtNombre.Text)) {
                MessageBox.Show("Ingresa un nombre");
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtTarjetaCredito.Text))
            {
                MessageBox.Show("Ingresa una tarjeta de crédito");
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Ingresa un teléfono de contacto");
                return false;
            }

            if(cboEstado.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un estado");
                return false;
            }

            if (cboTipoPersona.SelectedItem == null)
            {
                MessageBox.Show("Seleccione el tipo de persona");
                return false;
            }

            return true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }

            var cliente = new Cliente()
            {
                Nombre = txtNombre.Text,
                Cedula = txtCedula.Text,
                Telefono = txtTelefono.Text,
                LimiteCredito = nudLimiteCredito.Value,
                TarjetaCredito = txtTarjetaCredito.Text,
                TipoPersonaID = ((TipoPersona)cboTipoPersona.SelectedItem).ID,
                EstadoID = ((EstadoCliente)cboEstado.SelectedItem).ID
            };

            dbContext.Clientes.Add(cliente);
            dbContext.SaveChanges();
            OnNuevoClienteAdded(this, new NuevoClienteEventArgs() { Cliente = cliente });
            this.Close();
        }

        private void NudLimiteCredito_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtTarjetaCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }

    public class NuevoClienteEventArgs: EventArgs
    {
        public Cliente Cliente { get; set; }
    }
}
