using RentCar.DAL;
using RentCar.Forms.Clientes;
using RentCar.Forms.Empleados;
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

namespace RentCar.Forms.Inspección
{
    public partial class NuevaInspeccion : Form
    {
        private RentCarContext dbContext;
        private Cliente Cliente;
        private Vehiculo Vehiculo;
        private Empleado Empleado;
        public event EventHandler<NuevaInspeccionEventArgs> OnNuevaInspeccionAdded;
        public NuevaInspeccion(int? clienteID = null, int? vehiculoID = null, int? empleadoID = null)
        {

            dbContext = RentCarContext.Create();
            InitializeComponent();
            CargarCombustibles();

            if(clienteID != null)
            {
                this.Cliente = dbContext.Clientes.FirstOrDefault(c => c.ID == clienteID.Value);
                txtCliente.Text = $"{Cliente.ID} - {Cliente.Nombre}";
            }

            if(vehiculoID != null)
            {
                this.Vehiculo = dbContext.Vehiculos.FirstOrDefault(v => v.ID == vehiculoID.Value);
                txtVehiculo.Text = $"{Vehiculo.Marca} {Vehiculo.Modelo} ({Vehiculo.NumPlaca})";
            }

            if(empleadoID != null)
            {
                this.Empleado = dbContext.Empleados.FirstOrDefault(e => e.ID == empleadoID.Value);
                txtEmpleado.Text = $"{Empleado.ID} - {Empleado.Nombre} {Empleado.Apellido}";
            }
        }

        private void CargarCombustibles()
        {
            cboCombustible.Items.AddRange(dbContext.CantidadesCombustible.ToArray());
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        public bool Validar()
        {
            if(Cliente == null)
            {
                MessageBox.Show("Seleccione un cliente");
                return false;
            }

            if(Vehiculo == null)
            {
                MessageBox.Show("Seleccione un vehículo");
                return false;
            }

            if(Empleado == null)
            {
                MessageBox.Show("Seleccione un empleado responsable");
                return false;
            }

            if(cboCombustible.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un nivel de combustible");
                return false;
            }

            return true;
        }

        private void BtnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            var selector = new SelectorCliente();

            selector.OnClienteSeleccionado += (s, ev) =>
            {
                this.Cliente = ev.Cliente;
                txtCliente.Text = $"{Cliente.ID} - {Cliente.Nombre}";
            };

            selector.Show();
        }

        private void BtnSeleccionarVehiculo_Click(object sender, EventArgs e)
        {
            var selector = new SelectorVehiculo();

            selector.OnVehiculoSeleccionado += (s, ev) =>
            {
                this.Vehiculo = ev.Vehiculo;
                txtVehiculo.Text = $"{Vehiculo.Marca} {Vehiculo.Modelo} ({Vehiculo.NumPlaca})";

            };
            selector.Show();
        }

        private void BtnSeleccionarEmpleado_Click(object sender, EventArgs e)
        {
            var selector = new SelectorEmpleado();

            selector.OnEmpleadoSeleccionado += (s, ev) =>
            {
                this.Empleado = ev.Empleado;
                txtEmpleado.Text = $"{Empleado.ID} - {Empleado.Nombre} {Empleado.Apellido}";
            };
            selector.Show();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }

            
                var inspeccion = new Inspeccion()
                {
                    CantidadCombustibleID = ((CantidadCombustible)cboCombustible.SelectedItem).ID,
                    VehiculoID = Vehiculo.ID,
                    ClienteID = Cliente.ID,
                    TieneGato = cbTieneGato.Checked,
                    EstadoID = (int) ENUM_ESTADO_INSPECCION.VALIDA,
                    TieneRalladuras = cbRalladuras.Checked,
                    EstadoGoma1 = cbGomaDD.Checked,
                    EstadoGoma2 = cbGomaDI.Checked,
                    EstadoGoma3 = cbGomaTD.Checked,
                    EstadoGoma4 = cbGomaTI.Checked,
                    TieneGomaRepuesta = cbGomaRepuesto.Checked,
                    TieneRoturasCristal = cbCristal.Checked,
                    EmpleadoResponsableID = Empleado.ID,
                    Fecha = dtpFechaInspeccion.Value
                };

                dbContext.Inspecciones.Add(inspeccion);
                dbContext.SaveChanges();
                OnNuevaInspeccionAdded(this, new NuevaInspeccionEventArgs() { Inspeccion = inspeccion });
                this.Close();
            

            
        }

        private void TxtVehiculo_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class NuevaInspeccionEventArgs: EventArgs
    {
        public Inspeccion Inspeccion { get; set; }
    }
}
