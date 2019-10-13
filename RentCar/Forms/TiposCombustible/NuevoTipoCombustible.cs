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

namespace RentCar.Forms.TiposCombustible
{
    public partial class NuevoTipoCombustible : Form
    {
        private RentCarContext dbContext;
        public event EventHandler<NuevoTipoCombustibleEventArgs> OnNuevoTipoCombustibleAdded;
        public NuevoTipoCombustible()
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

            var TipoCombustible = new TipoCombustible()
            {
                Descripcion = txtDescripcion.Text,
                EstadoID = (int) ENUM_ESTADO_TIPO_COMBUSTIBLE.ACTIVO
            };

            dbContext.TiposCombustible.Add(TipoCombustible);
            dbContext.SaveChanges();
            OnNuevoTipoCombustibleAdded(this, new NuevoTipoCombustibleEventArgs { TipoCombustible = TipoCombustible });
            this.Close();
        }
    }

    public class NuevoTipoCombustibleEventArgs : EventArgs
    {
        public TipoCombustible TipoCombustible { get; set; }
    }
}
