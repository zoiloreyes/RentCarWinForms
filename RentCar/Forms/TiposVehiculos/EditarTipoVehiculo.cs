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
    public partial class EditarTipoVehiculo : Form
    {
        private RentCarContext dbContext;
        public event EventHandler<EditarTipoEventArgs> OnTipoActualizado;
        public EditarTipoVehiculo(int TipoVehiculoID)
        {
            dbContext = RentCarContext.Create();
            InitializeComponent();
            CargarEstados();
            CargarTipo(TipoVehiculoID);
        }

        public void CargarEstados()
        {
            cboEstado.Items.AddRange(dbContext.EstadosTipoVehiculo.ToArray());
        }

        public void CargarTipo(int TipoVehiculoID)
        {
            var TipoVehiculo = dbContext.TiposVehiculo.Find(TipoVehiculoID);
            if (TipoVehiculo == null)
                return;

            txtIdentificador.Text = TipoVehiculo.ID.ToString();
            txtDescripcion.Text = TipoVehiculo.Descripcion;
            cboEstado.SelectedItem = TipoVehiculo.Estado;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }


        private void CboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public bool Validar()
        {
            if(cboEstado.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un Estado");
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Ingrese una descripcion");
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

            var tipo = dbContext.TiposVehiculo.Find(int.Parse(txtIdentificador.Text));
            tipo.Descripcion = txtDescripcion.Text;
            tipo.EstadoID = ((EstadoTipoVehiculo)cboEstado.SelectedItem).ID;

            dbContext.SaveChanges();
            OnTipoActualizado(this, new EditarTipoEventArgs() { TipoVehiculo = tipo });
            this.Close();
        }

        private void EditarTipoVehiculo_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtIdentificador_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }
    }

    public class EditarTipoEventArgs : EventArgs
    {
        public TipoVehiculo TipoVehiculo { get; set; }
    }
}
