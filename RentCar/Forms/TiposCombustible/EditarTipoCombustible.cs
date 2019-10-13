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
    public partial class EditarTipoCombustible : Form
    {
        private RentCarContext dbContext;
        public event EventHandler<EditarTipoCombustibleEventArgs> OnTipoCombustibleActualizado;

        public EditarTipoCombustible(int TipoCombustibleID)
        {
            dbContext = RentCarContext.Create();
            InitializeComponent();
            CargarEstados();
            CargarTipo(TipoCombustibleID);
        }

        private void CargarTipo(int TipoCombustibleID)
        {
            var TipoCombustible = dbContext.TiposCombustible.Find(TipoCombustibleID);
            if (TipoCombustible == null)
                return;

            txtIdentificador.Text = TipoCombustible.ID.ToString();
            txtDescripcion.Text = TipoCombustible.Descripcion;
            cboEstado.SelectedItem = TipoCombustible.Estado;
        }

        private void CargarEstados()
        {
            cboEstado.Items.AddRange(dbContext.EstadosTipoCombustible.ToArray());
        }

        public bool Validar()
        {
            if (cboEstado.SelectedItem == null)
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

            var tipo = dbContext.TiposCombustible.Find(int.Parse(txtIdentificador.Text));
            tipo.Descripcion = txtDescripcion.Text;
            tipo.EstadoID = ((EstadoTipoCombustible)cboEstado.SelectedItem).ID;

            dbContext.SaveChanges();
            OnTipoCombustibleActualizado(this, new EditarTipoCombustibleEventArgs() { TipoCombustible = tipo });
            this.Close();
        }
    }

    public class EditarTipoCombustibleEventArgs : EventArgs
    {
        public TipoCombustible TipoCombustible { get; set; }
    }
}
