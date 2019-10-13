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

namespace RentCar.Forms
{

    public partial class NuevoTipoVehiculo : Form
    {
        private RentCarContext dbContext;
        public event EventHandler<NuevoTipoEventArgs> OnNuevoTipoAdded;

        public NuevoTipoVehiculo()
        {
            dbContext = RentCarContext.Create();
            InitializeComponent();
        }

        private bool Validar()
        {
            if (String.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Ingresa una descripción");
                return false;
            }

            return true;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }

            var TipoVehiculo = new TipoVehiculo()
            {
                Descripcion = txtDescripcion.Text,
                EstadoID = ((int)ENUM_ESTADO_TIPO_VEHICULO.ACTIVO)
            };

            dbContext.TiposVehiculo.Add(TipoVehiculo);
            dbContext.SaveChanges();
            OnNuevoTipoAdded(this, new NuevoTipoEventArgs { TipoVehiculo = TipoVehiculo });
            this.Close();
        }

        private void NuevoTipoVehiculo_Load(object sender, EventArgs e)
        {

        }
    }

    public class NuevoTipoEventArgs : EventArgs
    {
        public TipoVehiculo TipoVehiculo { get; set; }
    }
}
