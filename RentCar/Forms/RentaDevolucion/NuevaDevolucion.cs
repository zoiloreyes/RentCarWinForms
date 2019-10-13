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

namespace RentCar.Forms.RentaDevolucion
{
    public partial class NuevaDevolucion : Form
    {
        private RentCarContext dbContext;
        private Renta_Devolucion Devolucion;
        public event EventHandler<NuevaDevolucionEventArgs> OnNuevaDevolucionAdded;

        public NuevaDevolucion(int RentaID)
        {
            dbContext = RentCarContext.Create();
            InitializeComponent();

            Devolucion = dbContext.Rentas_Devoluciones
                            .Include(r => r.Estado)
                            .Include(r => r.Cliente)
                            .Include(r => r.Vehiculo)
                            /*.Include(r => r.Inspeccion)*/
                            .Include(r => r.Empleado)
                            .AsNoTracking()
                            .FirstOrDefault(r => r.ID == RentaID);

            ValidarRentado();
            Display();
        }

        private void ValidarRentado()
        {
            if(Devolucion.FechaDevolucion != null)
            {
                MessageBox.Show("Esta renta ya finalizó");
                this.Close();
            }
        }

        private void Display()
        {
            txtCliente.Text = $"{Devolucion.Cliente.ID} - {Devolucion.Cliente.Nombre}";
            txtComentario.Text = Devolucion.Comentario;
            txtEmpleado.Text = $"{Devolucion.Empleado.ID} - {Devolucion.Empleado.Nombre} {Devolucion.Empleado.Apellido}";
            txtVehiculo.Text = $"{Devolucion.Vehiculo.Marca} {Devolucion.Vehiculo.Modelo} ({Devolucion.Vehiculo.NumPlaca})";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var devolucion = dbContext.Rentas_Devoluciones.Include(r => r.Vehiculo).FirstOrDefault(d => d.ID == Devolucion.ID);

            devolucion.Comentario = txtComentario.Text;
            devolucion.FechaDevolucion = dtpFechaRenta.Value;

            devolucion.Vehiculo.EstadoID = (int)ENUM_ESTADO_VEHICULO.DISPONIBLE;

            dbContext.SaveChanges();
            OnNuevaDevolucionAdded(this, new NuevaDevolucionEventArgs()
            {
                RentaDevolucion = devolucion
            });
            this.Close();
        }
    }

    public class NuevaDevolucionEventArgs: EventArgs
    {
        public Renta_Devolucion RentaDevolucion { get; set; }
    }
}
