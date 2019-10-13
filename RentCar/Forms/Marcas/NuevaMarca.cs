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

namespace RentCar.Forms.Marcas
{


    public partial class NuevaMarca : Form
    {

        private RentCarContext dbContext;
        public event EventHandler<NuevaMarcaEventArgs> OnNuevaMarcaAdded;
        public NuevaMarca()
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

            var marca = new Marca()
            {
                Descripcion = txtDescripcion.Text,
                EstadoID = (int) ENUM_ESTADO_MARCA.ACTIVA
            };

            dbContext.Marcas.Add(marca);
            dbContext.SaveChanges();
            OnNuevaMarcaAdded(this, new NuevaMarcaEventArgs { Marca = marca });
            this.Close();
        }

        private void NuevaMarca_Load(object sender, EventArgs e)
        {

        }
    }

    public class NuevaMarcaEventArgs : EventArgs
    {
        public Marca Marca { get; set; }
    }
}
