using Microsoft.Reporting.WinForms;
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

namespace RentCar.Forms.Reportes
{
    public partial class ReportesMain : Form
    {
        private RentCarContext dbContext;
        private Cliente Cliente;
        private Empleado Empleado;
        private TipoVehiculo TipoVehiculo;

        public ReportesMain()
        {
            dbContext = RentCarContext.Create();
            InitializeComponent();
            CargarTiposVehiculo();
            CargarClientes();
            CargarEmpleados();
            LoadReport();
        }

        private void LoadReport()
        {
            this.rvRentas.LocalReport.DataSources[0].Value = dbContext.Rentas_Devoluciones
                                                                .Include(r => r.Cliente)
                                                                .Include(r => r.Empleado)
                                                                .Include(r => r.Vehiculo)
                                                                .Include(r => r.Vehiculo.Modelo)
                                                                .Include(r => r.Vehiculo.Marca)
                                                                .Include(r => r.Vehiculo.TipoVehiculo)
                                                                .ToList()
                                                                .Where(r => 
                                                                        (Cliente == null || r.ClienteID == Cliente.ID )
                                                                      &&(Empleado == null || r.EmpleadoID == Empleado.ID)
                                                                      &&(TipoVehiculo == null || r.Vehiculo.TipoVehiculoID == TipoVehiculo.ID)
                                                                      &&(r.FechaRenta >= dtpFechaMinima.Value)
                                                                      &&(!r.FechaDevolucion.HasValue || r.FechaDevolucion <= dtpFechaMaxima.Value || r.FechaRenta <= dtpFechaMaxima.Value)
                                                                )
                                                                .Select(r => new RentaDto()
                                                                {
                                                                    Cliente = r.Cliente.Nombre,
                                                                    Empleado = $"{r.Empleado.Nombre} {r.Empleado.Apellido}",
                                                                    FechaDevolucion = r.FechaDevolucion == null ? "N/A" : r.FechaDevolucion.Value.ToString("dd/MM/yyyy"),
                                                                    FechaRenta = r.FechaRenta.ToString("dd/MM/yyyy"),
                                                                    Marca = r.Vehiculo.Marca.Descripcion,
                                                                    Modelo = r.Vehiculo.Modelo.Descripcion,
                                                                    TipoVehiculo = r.Vehiculo.TipoVehiculo.Descripcion,
                                                                    Placa = r.Vehiculo.NumPlaca,
                                                                    Valor = r.MontoXDia * r.CantidadDias
                                                                }).ToList();
            this.rvRentas.RefreshReport();
        }

        private void CargarClientes()
        {
            cboClientes.Items.AddRange(dbContext.Clientes.OrderBy(t => t.Nombre).ToArray());
        }

        private void CargarEmpleados()
        {
            cboEmpleados.Items.AddRange(dbContext.Empleados.OrderBy(t => t.Nombre).ToArray());
        }

        private void CargarTiposVehiculo()
        {
            cboTipoVehiculo.Items.AddRange(dbContext.TiposCombustible.OrderBy(t => t.Descripcion).ToArray());
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ReportesMain_Load(object sender, EventArgs e)
        {

            this.rvRentas.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboClientes != null)
                Cliente = (Cliente)cboClientes.SelectedItem;
            else
                Cliente = null;

            LoadReport();
        }

        private void cboEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEmpleados != null)
                Empleado = (Empleado)cboEmpleados.SelectedItem;
            else
                Empleado = null;

            LoadReport();
        }

        private void cboTipoCombustible_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoVehiculo != null)
                TipoVehiculo = (TipoVehiculo)cboTipoVehiculo.SelectedItem;
            else
                TipoVehiculo = null;

            LoadReport();
        }

        private void dtpFechaMaxima_ValueChanged(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void dtpFechaMinima_ValueChanged(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void rentCarSP2BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal formMenu = new MenuPrincipal();
            formMenu.Show();
            this.Close();
        }

        private void btlLimpiar_Click(object sender, EventArgs e)
        {
            Cliente = null;
            Empleado = null;
            TipoVehiculo = null;
            dtpFechaMaxima.Value = new DateTime(9998,1,1);
            dtpFechaMinima.Value = new DateTime(1980,1,1);
            LoadReport();
        }
    }
}
