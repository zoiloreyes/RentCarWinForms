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
    public partial class SelectorCliente : Form
    {
        private RentCarContext dbContext;
        public event EventHandler<ClienteSeleccionadoEventArgs> OnClienteSeleccionado;

        public SelectorCliente()
        {
            dbContext = RentCarContext.Create();
            InitializeComponent();
            Display();
        }

        private void Display()
        {
            dgClientes.DataSource = dbContext.Clientes.Where(c => c.EstadoID == (int)ENUM_ESTADO_CLIENTE.ACTIVO).Select(c => new
            {
                Identificador = c.ID,
                c.Cedula,
                c.Nombre,
                c.LimiteCredito,
                TipoPersona = c.TipoPersona.Nombre
            }).ToList();
        }

        private void DgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgClientes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var idCliente = int.Parse(dgClientes.Rows[e.RowIndex].Cells[0].Value.ToString());
            var cliente = dbContext.Clientes.AsNoTracking().FirstOrDefault(c => c.ID == idCliente);
            this.OnClienteSeleccionado(this, new ClienteSeleccionadoEventArgs() { Cliente = cliente });
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }

    public class ClienteSeleccionadoEventArgs : EventArgs
    {
        public Cliente Cliente { get; set; }
    }
}
