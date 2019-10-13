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
    public partial class EditarMarca : Form
    {
        private RentCarContext dbContext;
        public event EventHandler<EditarMarcaEventArgs> OnMarcaActualizada;

        public EditarMarca(int MarcaID)
        {
            dbContext = RentCarContext.Create();
            InitializeComponent();
            CargarEstados();
            CargarMarca(MarcaID);
        }

        public void CargarEstados()
        {
            cboEstado.Items.AddRange(dbContext.EstadosMarca.ToArray());
        }

        public void CargarMarca(int MarcaID)
        {
            var Marca = dbContext.Marcas.Find(MarcaID);
            if (Marca == null)
                return;

            txtIdentificador.Text = Marca.ID.ToString();
            txtDescripcion.Text = Marca.Descripcion;
            cboEstado.SelectedItem = Marca.Estado;
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

            var marca = dbContext.Marcas.Find(int.Parse(txtIdentificador.Text));
            marca.Descripcion = txtDescripcion.Text;
            marca.EstadoID = ((EstadoMarca)cboEstado.SelectedItem).ID;

            dbContext.SaveChanges();
            OnMarcaActualizada(this, new EditarMarcaEventArgs() { Marca = marca });
            this.Close();
        }

        private void EditarMarca_Load(object sender, EventArgs e)
        {

        }
    }
    public class EditarMarcaEventArgs : EventArgs
    {
        public Marca Marca { get; set; }
    }
}
