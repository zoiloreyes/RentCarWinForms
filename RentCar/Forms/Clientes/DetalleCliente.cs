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

namespace RentCar.Forms.Clientes
{
    public partial class DetalleCliente : Form
    {
        private RentCarContext dbContext;
        public event EventHandler<EditarClienteEventArgs> OnClienteActualizado;
        public event EventHandler<EliminarClienteEventArgs> OnClienteEliminado;
        public Cliente Cliente;
        public DetalleCliente(int ClienteID)
        {
            dbContext = RentCarContext.Create();
            InitializeComponent();
            CargarCliente(ClienteID);
        }

        private void CargarCliente(int clienteID)
        {
            var cliente = dbContext.Clientes
                            .AsNoTracking()
                            .Include(c => c.Estado)
                            .Include(c => c.TipoPersona)
                            .FirstOrDefault(c => c.ID == clienteID);

            this.Cliente = cliente;
            lblTitulo.Text = $"{Cliente.ID} - {Cliente.Nombre}";
            lblIdentificador.Text = Cliente.ID.ToString();
            lblNombre.Text = Cliente.Nombre;
            lblLimite.Text = Cliente.LimiteCredito.ToString();
            lblTarjetaCredito.Text = Cliente.TarjetaCredito;
            lblTipo.Text = Cliente.TipoPersona.Nombre;
            lblEstado.Text = Cliente.Estado.Nombre;


        }

        private void DetalleCliente_Load(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var editarForm = new EditarCliente(Cliente.ID);
            editarForm.OnClienteActualizado += (s, ev) =>
            {

                MessageBox.Show("Cliente Actualizado");
                this.OnClienteActualizado(this, new EditarClienteEventArgs() { Cliente = ev.Cliente });
                this.CargarCliente(ev.Cliente.ID);
            };
            editarForm.Show();

        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            var aRemover = dbContext.Clientes.Find(Cliente.ID);
            aRemover.EstadoID = (int) ENUM_ESTADO_CLIENTE.INACTIVO;
            //var removido = dbContext.Clientes.Remove(aRemover);
            dbContext.SaveChanges();
            OnClienteEliminado(this, new EliminarClienteEventArgs() { Cliente = aRemover });
            this.Close();
        }
    }
    public class EliminarClienteEventArgs : EventArgs
    {
        public Cliente Cliente { get; set; }
    }
}
