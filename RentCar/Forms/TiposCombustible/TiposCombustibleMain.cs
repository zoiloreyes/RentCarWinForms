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

namespace RentCar.Forms.TiposCombustible
{
    public partial class TiposCombustibleMain : Form
    {
        private RentCarContext dbContext;
        public TiposCombustibleMain()
        {
            dbContext = RentCarContext.Create();
            InitializeComponent();
            Display();
        }

        private void Display()
        {
            dgTiposCombustible.DataSource = dbContext.TiposCombustible
                .Where(t => t.EstadoID == (int) ENUM_ESTADO_TIPO_COMBUSTIBLE.ACTIVO)
                .Select(c => new
            {
                Identificador = c.ID,
                Descripcion = c.Descripcion
            }).ToList();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal formMenu = new MenuPrincipal();
            formMenu.Show();
            this.Close();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            var nuevoForm = new NuevoTipoCombustible();
            nuevoForm.OnNuevoTipoCombustibleAdded += (s, ev) =>
            {
                MessageBox.Show("Tipo de Combustible Agregado");
                this.Display();
            };
            nuevoForm.Show();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgTiposCombustible.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }

            var ventana = new EditarTipoCombustible((int)dgTiposCombustible.SelectedRows[0].Cells[0].Value);
            ventana.OnTipoCombustibleActualizado += (s, ev) =>
            {
                MessageBox.Show("Tipo Actualizado");
                this.Display();
            };
            ventana.Show();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgTiposCombustible.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }

            var tipo = dbContext.TiposCombustible.Find((int)dgTiposCombustible.SelectedRows[0].Cells[0].Value);
            dbContext.TiposCombustible.Remove(tipo);
            dbContext.SaveChanges();
            this.Display();
        }

        private void DgTiposCombustible_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
