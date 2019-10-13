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

namespace RentCar.Forms.Inspección
{
    public partial class SelectorInspeccion : Form
    {
        private RentCarContext dbContext;
        public event EventHandler<InspeccionSeleccionadaEventArgs> OnInspeccionSeleccionada;

        public SelectorInspeccion()
        {
            dbContext = RentCarContext.Create();
            InitializeComponent();
            Display();
        }

        private void Display()
        {
            dgInspecciones.DataSource = dbContext.Inspecciones
                                        .Where(i => i.EstadoID == (int) ENUM_ESTADO_INSPECCION.VALIDA)
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
                                            PoseeGato = i.TieneGato ? "Sí" : "No",
                                            TieneRalladauras = i.TieneRalladuras ? "Sí" : "No",
                                            CristalDañado = i.TieneRoturasCristal ? "Sí" : "No"
                                        }).ToList();
        }

        private void DgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgInspecciones_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var idInspeccion = int.Parse(dgInspecciones.Rows[e.RowIndex].Cells[0].Value.ToString());
            var inspeccion = dbContext.Inspecciones.AsNoTracking().FirstOrDefault(i => i.ID == idInspeccion);

            this.OnInspeccionSeleccionada(this, new InspeccionSeleccionadaEventArgs() { Inspeccion = inspeccion });
            this.Close();
        }
    }

    public class InspeccionSeleccionadaEventArgs : EventArgs
    {
        public Inspeccion Inspeccion { get; set; }
    }
}
