using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentCar.Forms.Marcas;
using System.Windows.Forms;
using RentCar.Forms.Modelos;
using RentCar.Forms.TiposCombustible;
using RentCar.Forms.Vehículos;
using RentCar.Forms.Clientes;
using RentCar.Forms.Empleados;
using RentCar.Forms.Inspección;
using RentCar.Forms.RentaDevolucion;
using RentCar.Forms.Reportes;

namespace RentCar.Forms
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();

            gbMarcas.MouseClick += this.marcasClick;
            pbMarcas.MouseClick += this.marcasClick;
            lblMarcas.MouseClick += this.marcasClick;

            gbTiposCombustible.MouseClick += this.tiposCombustibleClick;
            pbTiposCombustible.MouseClick += this.tiposCombustibleClick;
            lblTiposCombustible.MouseClick += this.tiposCombustibleClick;

            gbModelos.MouseClick += this.modelosClick;
            pbModelos.MouseClick += this.modelosClick;
            lblModelos.MouseClick += this.modelosClick;

            gbTiposVehiculos.MouseClick += this.tiposVehiculosClick;
            pbTiposVehiculos.MouseClick += this.tiposVehiculosClick;
            lblTiposVehiculos.MouseClick += this.tiposVehiculosClick;

            gbVehiculos.MouseClick += this.vehiculosClick;
            pbVehiculos.MouseClick += this.vehiculosClick;
            lblVehiculos.MouseClick += this.vehiculosClick;

            gbClientes.MouseClick += this.clientesClick;
            pbCliente.MouseClick += this.clientesClick;
            lblCliente.MouseClick += this.clientesClick;

            gbEmpleados.MouseClick += this.empleadosClick;
            pbEmpleados.MouseClick += this.empleadosClick;
            lblEmpleados.MouseClick += this.empleadosClick;

            gbInspeccion.MouseClick += this.inspeccionClick;
            pbInspeccion.MouseClick += this.inspeccionClick;
            lblInspeccion.MouseClick += this.inspeccionClick;

            gbRentas.MouseClick += this.rentasClick;
            pbRentas.MouseClick += this.rentasClick;
            lblRentas.MouseClick += this.rentasClick;

            gbReportes.MouseClick += this.reportesClick;
            pbReportes.MouseClick += this.reportesClick;
            lblReportes.MouseClick += this.reportesClick;
        }

        private void marcasClick(object sender, EventArgs e)
        {
            var marcas = new MarcasMain();
            marcas.Show();
            this.Close();
        }

        private void tiposCombustibleClick(object sender, EventArgs e)
        {
            var tipoComb = new TiposCombustibleMain();
            tipoComb.Show();
            Close();
        }
        private void modelosClick(object sender, EventArgs e)
        {
            var modelos = new ModelosMain();
            modelos.Show();
            Close();
        }

        private void tiposVehiculosClick(object sender, EventArgs e)
        {
            var tipoVehi = new TiposDeVehiculo();
            tipoVehi.Show();
            Close();
        }

        private void vehiculosClick(object sender, EventArgs e)
        {
            var vehiculos = new VehiculosMain();
            vehiculos.Show();
            Close();
        }

        private void clientesClick(object sender, EventArgs e)
        {
            var clientes = new ClientesMain();
            clientes.Show();
            Close();
        }

        private void empleadosClick(object sender, EventArgs e)
        {
            var empleados = new EmpleadosMain();
            empleados.Show();
            Close();
        }

        private void inspeccionClick(object sender, EventArgs e)
        {
            var inspecciones = new InspeccionesMain();
            inspecciones.Show();
            Close();
        }

        private void rentasClick(object sender, EventArgs e)
        {
            var rentas = new RentasMain();
            rentas.Show();
            Close();
        }

        private void reportesClick(object sender, EventArgs e)
        {
            var reportes = new ReportesMain();
            reportes.Show();
            Close();
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void GbTiposCombustible_Enter(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void GbClientes_Enter(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Shown(object sender, EventArgs e)
        {

        }

        private void GbTiposVehiculos_Enter(object sender, EventArgs e)
        {

        }
    }
}
