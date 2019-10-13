using RentCar.DAL;
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
    public partial class RentasMain : Form
    {
        private RentCarContext dbContext;
        public RentasMain()
        {
            dbContext = RentCarContext.Create();
            InitializeComponent();
            Display();
        }

        private void Display()
        {
            dgRentas.DataSource = dbContext.Rentas_Devoluciones
                                    .Include(r => r.Cliente)
                                    .Include(r => r.Empleado)
                                    .Include(r => r.Estado)
                                    .Include(r => r.Vehiculo)
                                    .AsNoTracking()
                                    .ToList()
                                    .Select(rd => new
                                    {
                                        Identificador = rd.ID,
                                        Empleado = $"{rd.Empleado.Nombre} {rd.Empleado.Apellido}",
                                        Cliente = rd.Cliente.Nombre,
                                        Vehículo = $"{rd.Vehiculo.Marca} {rd.Vehiculo.Modelo} ({rd.Vehiculo.NumPlaca})",
                                        FechaAlquiler = rd.FechaRenta.ToString("dd/MM/yyyy"),
                                        FechaRetorno = rd.FechaDevolucion?.ToString("dd/MM/yyyy"),
                                        rd.MontoXDia,
                                        rd.CantidadDias,
                                        Estado = rd.Estado.Nombre
                                    }).ToList();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal formMenu = new MenuPrincipal();
            formMenu.Show();
            this.Close();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            NuevaRenta nuevaForm = new NuevaRenta();
            nuevaForm.OnNuevaRentaAdded += (s, ev) =>
            {
                MessageBox.Show($"Renta Registrada");
                this.Display();
            };

            nuevaForm.Show();
        }

        private void BtnDetalles_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(dgRentas.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una renta");
                return;
            }

            NuevaDevolucion devolucon = new NuevaDevolucion(int.Parse(dgRentas.SelectedRows[0].Cells[0].Value.ToString()));

            devolucon.OnNuevaDevolucionAdded += (s, ev) =>
            {
                MessageBox.Show("Devolución Registrada");
                this.Display();
            };

            devolucon.Show();
        }
    }
}
