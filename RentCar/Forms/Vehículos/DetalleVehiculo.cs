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
using System.Data.Entity;
using System.Windows.Forms;

namespace RentCar.Forms.Vehículos
{
    public partial class DetalleVehiculo : Form
    {
        private RentCarContext dbContext;
        public event EventHandler<EditarVehiculoEventArgs> OnVehiculoActualizado;
        public event EventHandler<EliminarVehiculoEventArgs> OnVehiculoEliminado;
        public Vehiculo Vehiculo;

        public DetalleVehiculo(int VehiculoID)
        {
            dbContext = RentCarContext.Create();
            InitializeComponent();
            CargarVehiculo(VehiculoID);
        }

        private void CargarVehiculo(int vehiculoID)
        {
            var vehiculo = dbContext.Vehiculos
                                    .Include(v => v.Marca)
                                    .Include(v => v.Modelo)
                                    .Include(v => v.Estado)
                                    .Include(v => v.TipoCombustible)
                                    .Include(v => v.TipoVehiculo)
                                    .AsNoTracking().FirstOrDefault(v => v.ID == vehiculoID);

            this.Vehiculo = vehiculo;
            lblTitulo.Text = $"{Vehiculo.ID} - {Vehiculo.Descripcion}";
            lblIdentificador.Text = Vehiculo.ID.ToString();
            lblDescripcion.Text = Vehiculo.Descripcion;
            lblEstado.Text = Vehiculo.Estado.Nombre;
            lblMarca.Text = Vehiculo.Marca.Descripcion;
            lblModelo.Text = Vehiculo.Modelo.Descripcion;
            lblChasis.Text = Vehiculo.NumChasis;
            lblMotor.Text = Vehiculo.NumMotor;
            lblPlaca.Text = Vehiculo.NumPlaca;
            lblTipoVehiculo.Text = Vehiculo.TipoVehiculo.Descripcion;
            lblTipoCombustible.Text = Vehiculo.TipoCombustible.Descripcion;

        }

        private void DetalleVehiculo_Load(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var editarForm = new EditarVehiculo(Vehiculo.ID);
            editarForm.OnVehiculoActualizado += (s, ev) =>
            {
                MessageBox.Show("Vehículo Actualizado");
                this.OnVehiculoActualizado(this, new EditarVehiculoEventArgs() { Vehiculo = ev.Vehiculo });
                this.CargarVehiculo(ev.Vehiculo.ID);
            };
            editarForm.Show();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            var aRemover = dbContext.Vehiculos.Find(Vehiculo.ID);
            var removido = dbContext.Vehiculos.Remove(aRemover);
            dbContext.SaveChanges();
            OnVehiculoEliminado(this, new EliminarVehiculoEventArgs() { Vehiculo = removido });
            this.Close();
        }
    }

    public class EliminarVehiculoEventArgs : EventArgs
    {
        public Vehiculo Vehiculo { get; set; }
    }
}
