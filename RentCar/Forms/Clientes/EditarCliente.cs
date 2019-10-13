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
using System.Windows.Forms;
using System.Data.Entity;
using RentCar.Extensions;

namespace RentCar.Forms.Clientes
{
    public partial class EditarCliente : Form
    {
        private RentCarContext dbContext;
        public event EventHandler<EditarClienteEventArgs> OnClienteActualizado;
        public EditarCliente(int ClienteID)
        {
            dbContext = RentCarContext.Create();
            InitializeComponent();
            CargarEstados();
            CargarTiposPersona();
            CargarCliente(ClienteID);
        }

        private void CargarCliente(int clienteID)
        {
            var Cliente = dbContext.Clientes
                                    .Find(clienteID);
            if (Cliente == null)
                return;

            lblTitulo.Text = $"{Cliente.ID.ToString()} - {Cliente.Nombre}";
            txtCedula.Text = Cliente.Cedula;
            txtNombre.Text = Cliente.Nombre;
            txtIdentificador.Text = Cliente.ID.ToString();
            nudLimiteCredito.Value = Cliente.LimiteCredito;
            txtTarjetaCredito.Text = Cliente.TarjetaCredito;
            txtTelefono.Text = Cliente.Telefono;
            cboEstado.SelectedItem = Cliente.Estado;
            cboTipoPersona.SelectedItem = Cliente.TipoPersona;
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
                MessageBox.Show("Céedula no válida");
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtNombre.Text))
            {
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

            if (cboEstado.SelectedItem == null)
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

        private void CargarTiposPersona()
        {
            cboTipoPersona.Items.AddRange(dbContext.TiposPersona.ToArray());
        }

        private void CargarEstados()
        {
            cboEstado.Items.AddRange(dbContext.EstadosCliente.ToArray());
        }

        private void EditarCliente_Load(object sender, EventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }

            var cliente = dbContext.Clientes.Find(int.Parse(txtIdentificador.Text));

            cliente.Nombre = txtNombre.Text;
            cliente.Cedula = txtCedula.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.LimiteCredito = nudLimiteCredito.Value;
            cliente.TarjetaCredito = txtTarjetaCredito.Text;
            cliente.TipoPersonaID = ((TipoPersona)cboTipoPersona.SelectedItem).ID;
            cliente.EstadoID = ((EstadoCliente)cboEstado.SelectedItem).ID;

            dbContext.SaveChanges();
            OnClienteActualizado(this, new EditarClienteEventArgs() { Cliente = cliente });
            this.Close();
        }

        private void TxtTarjetaCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
    }

    public class EditarClienteEventArgs : EventArgs
    {
        public Cliente Cliente { get; set; }
    }
}
