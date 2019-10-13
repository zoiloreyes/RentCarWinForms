using RentCar.DAL;
using RentCar.Forms.Clientes;
using RentCar.Forms.Empleados;
using RentCar.Forms.Inspección;
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

namespace RentCar.Forms.RentaDevolucion
{
    public partial class NuevaRenta : Form
    {
        private RentCarContext dbContext;
        private Cliente Cliente;
        private Empleado Empleado;
        private Vehiculo Vehiculo;
        private Inspeccion Inspeccion;
        public event EventHandler<NuevaRentaEventArgs> OnNuevaRentaAdded;
        public NuevaRenta()
        {
            dbContext = RentCarContext.Create();
            InitializeComponent();
        }

        private void NuevaRenta_Load(object sender, EventArgs e)
        {

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

        private void BtnSeleccionarInspeccion_Click(object sender, EventArgs e)
        {
            if(Vehiculo == null)
            {
                MessageBox.Show("Seleccione un vehículo");
                return;
            }

            var selector = new SelectorInspeccion();

            selector.OnInspeccionSeleccionada += (s, ev) =>
            {
                this.Inspeccion = ev.Inspeccion;
                txtInspeccion.Text = $"Inspección No. {Inspeccion.ID}";
            };

            selector.Show();
        }

        public bool Validar()
        {
            if (Cliente == null)
            {
                MessageBox.Show("Seleccione un cliente");
                return false;
            }

            if (Vehiculo == null)
            {
                MessageBox.Show("Seleccione un vehículo");
                return false;
            }

            if (Empleado == null)
            {
                MessageBox.Show("Seleccione un empleado responsable");
                return false;
            }

            if (Inspeccion == null)
            {
                MessageBox.Show("Vinculo la inspeccion a la renta");
                return false;
            }

            if(this.Inspeccion.VehiculoID != this.Vehiculo.ID)
            {
                MessageBox.Show("El vehiculo no coincide con la inspección");
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

            var renta = new Renta_Devolucion()
            {
                ID = 0,
                VehiculoID = Vehiculo.ID,
                ClienteID = Cliente.ID,
                EmpleadoID = Empleado.ID,
                InspeccionID = Inspeccion.ID,
                FechaRenta = dtpFechaRenta.Value,
                Comentario = txtComentario.Text,
                MontoXDia = nupMonto.Value,
                CantidadDias = (int) nupDias.Value,
                EstadoID = (int)ENUM_ESTAD_RENTA_DEVOLUCION.VALIDA
            };

            var vehiculo = dbContext.Vehiculos.Find(Vehiculo.ID);
            vehiculo.EstadoID = (int)ENUM_ESTADO_VEHICULO.RENTADO;

            dbContext.Rentas_Devoluciones.Add(renta);
            dbContext.SaveChanges();
            OnNuevaRentaAdded(this, new NuevaRentaEventArgs() { RentaDevolucion = renta });
            this.Close();

        }

        private void BtnNuevaInspeccion_Click(object sender, EventArgs e)
        {
            if (Vehiculo == null)
            {
                MessageBox.Show("Seleccione un vehículo");
                return;
            }

            NuevaInspeccion nuevaForm = new NuevaInspeccion(Cliente?.ID, Vehiculo?.ID, Empleado?.ID);
            nuevaForm.OnNuevaInspeccionAdded += (s, ev) =>
            {
                if(ev.Inspeccion.VehiculoID != this.Vehiculo.ID)
                {
                    MessageBox.Show("La inspección no corresponde al vehículo");
                    return;
                }
                this.Inspeccion = ev.Inspeccion;
                txtInspeccion.Text = $"Inspección No. {Inspeccion.ID}";
            };

            nuevaForm.Show();
        }

    }

    public class NuevaRentaEventArgs: EventArgs
    {
        public Renta_Devolucion RentaDevolucion { get; set; }
    }
}
