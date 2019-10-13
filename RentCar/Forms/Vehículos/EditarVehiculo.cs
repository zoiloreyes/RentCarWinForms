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
    public partial class EditarVehiculo : Form
    {
        private RentCarContext dbContext;
        public event EventHandler<EditarVehiculoEventArgs> OnVehiculoActualizado;
        public EditarVehiculo(int VehiculoID)
        {
            dbContext = RentCarContext.Create();
            InitializeComponent();
            CargarEstados();
            CargarMarcas();
            CargarModelos();
            CargarTiposVehiculo();
            CargarTiposCombustible();
            CargarVehiculo(VehiculoID);
        }

        private void CargarVehiculo(int vehiculoID)
        {
            var Vehiculo = dbContext.Vehiculos
                                    .Include(v => v.Marca)
                                    .Include(v => v.Modelo)
                                    .Include(v => v.Estado)
                                    .Include(v => v.TipoCombustible)
                                    .Include(v => v.TipoVehiculo)
                                    .AsNoTracking().FirstOrDefault(v => v.ID == vehiculoID);
            if (Vehiculo == null)
                return;

            lblTitulo.Text = $"{Vehiculo.ID.ToString()} - {Vehiculo.Descripcion}";
            txtIdentificador.Text = Vehiculo.ID.ToString();
            txtDescripcion.Text = Vehiculo.Descripcion;
            cboEstados.SelectedItem = Vehiculo.Estado;
            cboMarca.SelectedItem = Vehiculo.Marca;
            cboModelo.SelectedItem = Vehiculo.Modelo;
            txtNoChasis.Text = Vehiculo.NumChasis;
            txtNoMotor.Text = Vehiculo.NumMotor;
            txtPlaca.Text = Vehiculo.NumPlaca;
            cboTipoCombustible.SelectedItem = Vehiculo.TipoCombustible;
            cboTipoVehiculo.SelectedItem = Vehiculo.TipoVehiculo;
        }

        private void CargarTiposCombustible()
        {
            cboTipoCombustible.Items.AddRange(dbContext.TiposCombustible.OrderBy(t => t.Descripcion).ToArray());
        }

        private void CargarTiposVehiculo()
        {
            cboTipoVehiculo.Items.AddRange(dbContext.TiposVehiculo.OrderBy(t => t.Descripcion).ToArray());
        }

        private void CargarModelos()
        {
            cboModelo.Items.AddRange(dbContext.Modelos.OrderBy(t => t.Descripcion).ToArray());
        }

        private void CargarMarcas()
        {
            cboMarca.Items.AddRange(dbContext.Marcas.OrderBy(t => t.Descripcion).ToArray());
        }

        private void CargarEstados()
        {
            cboEstados.Items.AddRange(dbContext.EstadosVehiculo.OrderBy(t => t.Nombre).ToArray());
        }

        public bool Validar()
        {
            if (String.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Ingresa una descripción");
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtNoChasis.Text))
            {
                MessageBox.Show("Ingresa un número de chasis");
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtNoMotor.Text))
            {
                MessageBox.Show("Ingresa un número de motor");
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtPlaca.Text))
            {
                MessageBox.Show("Ingresa la placa");
                return false;
            }

            if (cboEstados.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un estado");
                return false;
            }

            if (cboMarca.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una marca");
                return false;
            }

            if (cboModelo.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un modelo");
                return false;
            }

            if (cboTipoCombustible.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tipo de combustible");
                return false;
            }

            if (cboTipoVehiculo.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tipo de vehículo");
                return false;
            }

            return true;
        }
        private void TxtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void CboTipoCombustible_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void CboTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }


        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }

            var vehiculo = dbContext.Vehiculos.Find(int.Parse(txtIdentificador.Text));
            vehiculo.Descripcion = txtDescripcion.Text;
            vehiculo.EstadoID = ((EstadoVehiculo)cboEstados.SelectedItem).ID;
            vehiculo.MarcaID = ((Marca)cboMarca.SelectedItem).ID;
            vehiculo.ModeloID = ((Modelo)cboModelo.SelectedItem).ID;
            vehiculo.NumChasis = txtNoChasis.Text;
            vehiculo.NumMotor = txtNoMotor.Text;
            vehiculo.NumPlaca = txtPlaca.Text;
            dbContext.SaveChanges();
            OnVehiculoActualizado(this, new EditarVehiculoEventArgs() { Vehiculo = vehiculo });
            this.Close();
        }

        private void EditarVehiculo_Load(object sender, EventArgs e)
        {

        }
    }

    public class EditarVehiculoEventArgs : EventArgs
    {
        public Vehiculo Vehiculo { get; set; }
    }
}
