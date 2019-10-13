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

namespace RentCar.Forms.Vehículos
{
    public partial class NuevoVehiculo : Form
    {
        private RentCarContext dbContext;
        public event EventHandler<NuevoVehiculoEventArgs> OnNuevoVehiculoAdded;
        public NuevoVehiculo()
        {
            dbContext = RentCarContext.Create();
            InitializeComponent();
            CargarEstados();
            CargarMarcas();
            CargarModelos();
            CargarTiposVehiculo();
            CargarTiposCombustible();
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
            cboModelo.Items.Clear();
            //var marcaID = ((Marca)cboMarca.SelectedItem).ID;
            if(cboMarca.SelectedItem == null)
            {
                cboModelo.Items.AddRange(dbContext.Modelos.OrderBy(t => t.Descripcion).ToArray());
            }
            else
            {
                cboModelo.Items.AddRange(dbContext.Modelos.Where(m => m.MarcaID == ((Marca)cboMarca.SelectedItem).ID).OrderBy(t => t.Descripcion).ToArray());

            }
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

            if(cboModelo.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un modelo");
                return false;
            }

            if(cboTipoCombustible.SelectedItem == null)
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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }

            var vehiculo = new Vehiculo()
            {
                Descripcion = txtDescripcion.Text,
                EstadoID = ((EstadoVehiculo)cboEstados.SelectedItem).ID,
                MarcaID = ((Marca)cboMarca.SelectedItem).ID,
                ModeloID = ((Modelo)cboModelo.SelectedItem).ID,
                TipoCombustibleID = ((TipoCombustible)cboTipoCombustible.SelectedItem).ID,
                TipoVehiculoID = ((TipoVehiculo)cboTipoVehiculo.SelectedItem).ID,
                NumChasis = txtNoChasis.Text,
                NumMotor = txtNoMotor.Text,
                NumPlaca = txtPlaca.Text
            };

            dbContext.Vehiculos.Add(vehiculo);
            dbContext.SaveChanges();
            OnNuevoVehiculoAdded(this, new NuevoVehiculoEventArgs() { Vehiculo = vehiculo });
            this.Close();
        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void CboTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void NuevoVehiculo_Load(object sender, EventArgs e)
        {

        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarModelos();
        }
    }

    public class NuevoVehiculoEventArgs: EventArgs
    {
        public Vehiculo Vehiculo { get; set; }
    }
}
