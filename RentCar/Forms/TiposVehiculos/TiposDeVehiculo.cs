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

namespace RentCar.Forms
{
    public partial class TiposDeVehiculo : Form
    {
        private RentCarContext dbContext;

        public TiposDeVehiculo()
        {
            dbContext = RentCarContext.Create();
            InitializeComponent();
            Display();
        }

        private void Display()
        {
            dgTiposVehiculo.DataSource = dbContext.TiposVehiculo.Where(t => t.EstadoID == (int) ENUM_ESTADO_TIPO_VEHICULO.ACTIVO)
            .Select(s => new
                {
                    Identificador = s.ID,
                    Descripcion = s.Descripcion
                }).ToList();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            NuevoTipoVehiculo nuevoForm = new NuevoTipoVehiculo();
            nuevoForm.Show();
            nuevoForm.OnNuevoTipoAdded += (s, ev) =>
            {
                MessageBox.Show("Tipo de Vehiculo Agregado");
                this.Display();
            };
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if(dgTiposVehiculo.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }

            var ventana = new EditarTipoVehiculo((int) dgTiposVehiculo.SelectedRows[0].Cells[0].Value);
            ventana.OnTipoActualizado += (s, ev) =>
            {
                MessageBox.Show("Tipo Actualizado");
                this.Display();
            };
            ventana.Show();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgTiposVehiculo.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }

            var tipo = dbContext.TiposVehiculo.Find((int)dgTiposVehiculo.SelectedRows[0].Cells[0].Value);

            tipo.EstadoID = (int)ENUM_ESTADO_TIPO_VEHICULO.INACTIVO;
            dbContext.SaveChanges();
            this.Display();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal formMenu = new MenuPrincipal();
            formMenu.Show();
            this.Close();
        }

        private void TiposDeVehiculo_Load(object sender, EventArgs e)
        {

        }

        private void DgTiposVehiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
