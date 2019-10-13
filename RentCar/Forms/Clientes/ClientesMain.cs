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

namespace RentCar.Forms.Clientes
{
    public partial class ClientesMain : Form
    {
        private RentCarContext dbContext;
        public ClientesMain()
        {
            RentaDto ds = new RentaDto();
            dbContext = RentCarContext.Create();
            InitializeComponent();
            Display();
        }

        private void Display()
        {
            dgClientes.DataSource = dbContext.Clientes.Where(c => c.EstadoID == (int) ENUM_ESTADO_CLIENTE.ACTIVO).Select(c => new
            {
                Identificador = c.ID,
                c.Cedula,
                c.Nombre,
                //c.TarjetaCredito,
                Limite_de_Credito = c.LimiteCredito,
                Tipo_Persona = c.TipoPersona.Nombre,
            }).ToList()
            .Where(e => (String.IsNullOrWhiteSpace(txtBuscar.Text) || e.Cedula.ToLower().Contains(txtBuscar.Text.ToLower()))
                            || (String.IsNullOrWhiteSpace(txtBuscar.Text) || e.Nombre.ToLower().Contains(txtBuscar.Text.ToLower()))
                            || (String.IsNullOrWhiteSpace(txtBuscar.Text) || e.Identificador.ToString().Contains(txtBuscar.Text.ToLower()))).ToList();
        }

        private void BtnDetalles_Click(object sender, EventArgs e)
        {
            if (dgClientes.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }

            var detalleform = new DetalleCliente((int)dgClientes.SelectedRows[0].Cells[0].Value);
            detalleform.OnClienteEliminado += (s, ev) =>
            {
                this.Display();
            };

            detalleform.OnClienteActualizado += (s, ev) =>
            {
                this.Display();
            };
            detalleform.Show();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            NuevoCliente nuevoForm = new NuevoCliente();
            nuevoForm.Show();
            nuevoForm.OnNuevoClienteAdded += (s, ev) =>
            {
                MessageBox.Show("Nuevo cliente agregado");
                this.Display();
            };
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if(dgClientes.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }

            var editForm = new EditarCliente((int)dgClientes.SelectedRows[0].Cells[0].Value);
            editForm.OnClienteActualizado += (s, ev) =>
            {
                MessageBox.Show("Cliente Actualizado");
                this.Display();
            };
            editForm.Show();
            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if(dgClientes.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }

            var cliente = dbContext.Clientes.Find((int)dgClientes.SelectedRows[0].Cells[0].Value);
            cliente.EstadoID = (int)ENUM_ESTADO_CLIENTE.INACTIVO;
            dbContext.SaveChanges();
            this.Display();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal formMenu = new MenuPrincipal();
            formMenu.Show();
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Display();
        }
    }
}
