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

namespace RentCar.Forms.Marcas
{
    public partial class MarcasMain : Form
    {
        private RentCarContext dbContext;

        public MarcasMain()
        {
            dbContext = RentCarContext.Create();
            InitializeComponent();
            Display();
        }

        private void Display()
        {
            dgMarcas.DataSource = dbContext.Marcas.Where(m => m.EstadoID == (int) ENUM_ESTADO_MARCA.ACTIVA).Select(m => new
            {
                Identificador = m.ID,
                m.Descripcion
            }).ToList();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            NuevaMarca nuevoForm = new NuevaMarca();
            nuevoForm.Show();
            nuevoForm.OnNuevaMarcaAdded += (s, ev) =>
            {
                MessageBox.Show("Nueva marca agregada");
                this.Display();
            };
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if(dgMarcas.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }

            var editarForm = new EditarMarca((int)dgMarcas.SelectedRows[0].Cells[0].Value);
            editarForm.OnMarcaActualizada += (s, ev) =>
            {
                MessageBox.Show("Marca actualizada");
                this.Display();
            };
            editarForm.Show();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgMarcas.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }

            var marca = dbContext.Marcas.Find((int)dgMarcas.SelectedRows[0].Cells[0].Value);
            dbContext.Marcas.Remove(marca);
            dbContext.SaveChanges();
            this.Display();
        }

        private void MarcasMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal formMenu = new MenuPrincipal();
            formMenu.Show();
            this.Close();
        }

        private void DgMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
