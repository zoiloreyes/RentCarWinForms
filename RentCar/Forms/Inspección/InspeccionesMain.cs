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

namespace RentCar.Forms.Inspección
{
    public partial class InspeccionesMain : Form
    {
        private RentCarContext dbContext;
        public InspeccionesMain()
        {
            dbContext = RentCarContext.Create();
            InitializeComponent();
            Display();
        }

        private void Display()
        {
            dgInspecciones.DataSource = dbContext.Inspecciones
                                        .Include(i => i.Vehiculo)
                                        .Include(i => i.Cliente)
                                        .Include(i => i.EmpleadoResponsable)
                                        .Include(i => i.Estado)
                                        .Include(i => i.CantidadCombustible)
                                        .AsNoTracking()
                                        .ToList()
                                        .Select(i => new
                                        {
                                            Identificador = i.ID,
                                            Vehiculo = $"{i.Vehiculo.Marca} {i.Vehiculo.Modelo} ({i.Vehiculo.NumPlaca})",
                                            Cliente = $"{i.Cliente.Nombre} ({i.Cliente.Cedula})",
                                            CantidadCombustible = i.CantidadCombustible.Nombre,
                                            GomaRepuesta = i.TieneGomaRepuesta ? "Sí" : "No",
                                            PoseeGato = i.TieneGato? "Sí": "No",
                                            TieneRalladauras = i.TieneRalladuras? "Sí": "No",
                                            CristalDañado = i.TieneRoturasCristal? "Sí": "No"
                                        }).ToList();
        }

        private void BtnDetalles_Click(object sender, EventArgs e)
        {
            if(dgInspecciones.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }

            var detalleForm = new DetalleInspeccion((int)dgInspecciones.SelectedRows[0].Cells[0].Value);
            detalleForm.Show();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            NuevaInspeccion nuevaForm = new NuevaInspeccion();
            nuevaForm.OnNuevaInspeccionAdded += (s, ev) =>
            {
                MessageBox.Show($"Inspección Registrada");
                this.Display();
            };

            nuevaForm.Show();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal formMenu = new MenuPrincipal();
            formMenu.Show();
            this.Close();
        }

        private void DgInspecciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InspeccionesMain_Load(object sender, EventArgs e)
        {

        }
    }
}
