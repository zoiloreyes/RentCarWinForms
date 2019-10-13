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

namespace RentCar.Forms.Modelos
{
    public partial class ModelosMain : Form
    {
        private RentCarContext dbContext;
        public ModelosMain()
        {
            dbContext = RentCarContext.Create();
            InitializeComponent();
            Display();
        }

        private void Display()
        {
            dgModelos.DataSource = dbContext.Modelos.Where(m => m.EstadoID == (int) ENUM_ESTADO_MODELO.ACTIVO).Select(m => new
            {
                Identificador = m.ID,
                m.Descripcion,
                Marca = m.Marca.Descripcion
            }).ToList();
        }

        private void DgMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            NuevoModelo nuevoForm = new NuevoModelo();
            nuevoForm.Show();
            nuevoForm.OnNuevoModeloAdded += (s, ev) =>
            {
                MessageBox.Show("Nuevo modelo agregado");
                this.Display();
            };
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if(dgModelos.SelectedRows.Count != 1)
            {
                MessageBox.Show("Selecione una fila");
                return;
            }

            var editarForm = new EditarModelo((int)dgModelos.SelectedRows[0].Cells[0].Value);
            editarForm.OnModeloActualizado += (s, ev) =>
            {
                MessageBox.Show("Modelo actualizado");
                this.Display();
            };
            editarForm.Show();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if(dgModelos.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }

            var modelo = dbContext.Modelos.Find((int)dgModelos.SelectedRows[0].Cells[0].Value);
            dbContext.Modelos.Remove(modelo);
            dbContext.SaveChanges();
            this.Display();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btnsasar_Click(object sender, EventArgs e)
        {

        }

        private void ModelosMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal formMenu = new MenuPrincipal();
            formMenu.Show();
            this.Close();
        }

        private void BtnDetalles_Click(object sender, EventArgs e)
        {
            if (dgModelos.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }
            var detalleFrom = new DetalleModelo((int)dgModelos.SelectedRows[0].Cells[0].Value);


            detalleFrom.OnModeloEliminado += (s, ev) =>
            {
                MessageBox.Show($"Modelo {ev.Modelo.Descripcion} eliminado");
                this.Display();
            };
            detalleFrom.Show();

        }
    }
}
