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

namespace RentCar.Forms.Inspección
{
    public partial class DetalleInspeccion : Form
    {
        private RentCarContext dbContext;
        private Inspeccion Inspeccion;

        public DetalleInspeccion(int InspeccionID)
        {
            dbContext = RentCarContext.Create();
            InitializeComponent();
            CargarInspeccion(InspeccionID);

        }

        private void CargarInspeccion(int inspeccionID)
        {
            var inspeccion = dbContext.Inspecciones
                                .Include(i => i.CantidadCombustible)
                                .Include(i => i.Vehiculo)
                                .Include(i => i.Vehiculo.Modelo)
                                .Include(i => i.Vehiculo.Marca)
                                .Include(i => i.Vehiculo.TipoCombustible)
                                .Include(i => i.Vehiculo.TipoVehiculo)
                                .Include(i => i.EmpleadoResponsable)
                                .Include(i => i.EmpleadoResponsable.TandaLaboral)
                                .Include(i => i.Cliente)
                                .Include(i => i.Cliente.TipoPersona)
                                .FirstOrDefault(i => i.ID == inspeccionID);

            this.Inspeccion = inspeccion;

            lblIdentificador.Text = Inspeccion.ID.ToString();
            lblFecha.Text = Inspeccion.Fecha.ToString("dd/MM/yyyy");
            lblCombustible.Text = Inspeccion.CantidadCombustible.Nombre;
            lblIdentificadorVehiculo.Text = Inspeccion.Vehiculo.ID.ToString();
            lblMarca.Text = Inspeccion.Vehiculo.Marca.Descripcion;
            lblModelo.Text = Inspeccion.Vehiculo.Modelo.Descripcion;
            lblTipoCombustible.Text = Inspeccion.Vehiculo.TipoCombustible.Descripcion;
            lblPlaca.Text = Inspeccion.Vehiculo.NumPlaca;
            lblTipoVehiculo.Text = Inspeccion.Vehiculo.TipoVehiculo.Descripcion;
            lblIdentificadorEmpleado.Text = Inspeccion.EmpleadoResponsable.ID.ToString();
            lblNombreEmpleado.Text = $"{Inspeccion.EmpleadoResponsable.Nombre} {Inspeccion.EmpleadoResponsable.Apellido}";
            lblCedula.Text = Inspeccion.EmpleadoResponsable.Cedula;
            lblTandaLaboral.Text = Inspeccion.EmpleadoResponsable.TandaLaboral.Nombre;
            lblIdentificadorCliente.Text = Inspeccion.Cliente.ID.ToString();
            lblCedulaCliente.Text = Inspeccion.Cliente.Cedula;
            lblNombreCliente.Text = Inspeccion.Cliente.Nombre;
            lblTelefonoCliente.Text = Inspeccion.Cliente.Telefono;
            lblLimiteCliente.Text = Inspeccion.Cliente.LimiteCredito.ToString();
            lblTipoPersona.Text = Inspeccion.Cliente.TipoPersona.Nombre;

            cbGomaDD.Checked = Inspeccion.EstadoGoma1;
            cbGomaDI.Checked = Inspeccion.EstadoGoma2;
            cbGomaTD.Checked = Inspeccion.EstadoGoma3;
            cbGomaTI.Checked = Inspeccion.EstadoGoma4;
            cbGomaRepuesto.Checked = Inspeccion.TieneGomaRepuesta;
            cbCristal.Checked = Inspeccion.TieneRoturasCristal;
            cbTieneGato.Checked = Inspeccion.TieneGato;
            cbRalladuras.Checked = Inspeccion.TieneRalladuras;
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void DetalleInspeccion_Load(object sender, EventArgs e)
        {

        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            /*TODO: Realizar impresion de formulario de firma*/
            MessageBox.Show("En construcción");
        }
    }
}
