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

namespace RentCar.Forms.Inspección
{
    public partial class SelectorVehiculo : Form
    {
        private RentCarContext dbContext;
        public event EventHandler<VehiculoSeleccionadoEventArgs> OnVehiculoSeleccionado;
        public SelectorVehiculo()
        {
            dbContext = RentCarContext.Create();
            InitializeComponent();
            Display();
        }

        private void Display()
        {
            dgVehiculos.DataSource = dbContext.Vehiculos.Where(v => v.EstadoID == (int)ENUM_ESTADO_VEHICULO.DISPONIBLE).Select(v => new
            {
                Identificador = v.ID,
                v.Descripcion,
                Marca = v.Marca.Descripcion,
                Modelo = v.Modelo.Descripcion,
                Tipo = v.TipoVehiculo.Descripcion,
                Combustible = v.TipoCombustible.Descripcion
            }).ToList();
        }

        private void DgVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgVehiculos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var idVehiculo = int.Parse(dgVehiculos.Rows[e.RowIndex].Cells[0].Value.ToString());
            var vehiculo = dbContext.Vehiculos
                                    .Include(v => v.Modelo)
                                    .Include(v => v.Marca)
                                    .Include(v => v.TipoCombustible)
                                    .Include(v => v.Estado)
                                    .AsNoTracking()
                                    .FirstOrDefault(v => v.ID == idVehiculo);

            this.OnVehiculoSeleccionado(this, new VehiculoSeleccionadoEventArgs() { Vehiculo = vehiculo });
            this.Close();
        }
    }

    public class VehiculoSeleccionadoEventArgs: EventArgs
    {
        public Vehiculo Vehiculo { get; set; }
    }
}
