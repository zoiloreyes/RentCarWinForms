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

namespace RentCar.Forms.Vehículos
{
    public partial class VehiculosMain : Form
    {
        private RentCarContext dbContext;

        public VehiculosMain()
        {
            dbContext = RentCarContext.Create();
            InitializeComponent();
            Display();
        }

        private void Display()
        {
            dgVehiculos.DataSource = dbContext.Vehiculos.Where(v => v.EstadoID == (int) ENUM_ESTADO_VEHICULO.DISPONIBLE ).Select(v => new
            {
                Identificador = v.ID,
                v.Descripcion,
                Marca = v.Marca.Descripcion,
                Modelo = v.Modelo.Descripcion,
                Tipo = v.TipoVehiculo.Descripcion,
                Combustible = v.TipoCombustible.Descripcion
            }).ToList();
        }

        private void BtnDetalles_Click(object sender, EventArgs e)
        {
            if(dgVehiculos.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }

            var detalleForm = new DetalleVehiculo((int)dgVehiculos.SelectedRows[0].Cells[0].Value);

            detalleForm.OnVehiculoEliminado += (s, ev) =>
            {
                this.Display();
            };

            detalleForm.OnVehiculoActualizado += (s, ev) =>
            {
                this.Display();
            };
            detalleForm.Show();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            NuevoVehiculo nuevoForm = new NuevoVehiculo();
            nuevoForm.Show();
            nuevoForm.OnNuevoVehiculoAdded += (s, ev) =>
            {
                MessageBox.Show("Nuevo vehículo agregado");
                this.Display();
            };
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal formMenu = new MenuPrincipal();
            formMenu.Show();
            this.Close();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgVehiculos.SelectedRows.Count != 1)
            {
                MessageBox.Show("Selecione una fila");
                return;
            }

            var editarForm = new EditarVehiculo((int)dgVehiculos.SelectedRows[0].Cells[0].Value);
            editarForm.OnVehiculoActualizado += (s, ev) =>
            {
                MessageBox.Show("Modelo actualizado");
                this.Display();
            };
            editarForm.Show();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgVehiculos.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }

            var vehiculo = dbContext.Vehiculos.Find((int)dgVehiculos.SelectedRows[0].Cells[0].Value);
            dbContext.Vehiculos.Remove(vehiculo);
            dbContext.SaveChanges();
            this.Display();
        }

        private void VehiculosMain_Load(object sender, EventArgs e)
        {

        }

        private void DgVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
