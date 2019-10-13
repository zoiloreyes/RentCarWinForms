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

namespace RentCar.Forms.Modelos
{
    public partial class EditarModelo : Form
    {
        private RentCarContext dbContext;
        public event EventHandler<EditarModeloEventArgs> OnModeloActualizado;

        public EditarModelo(int ModeloID)
        {
            dbContext = RentCarContext.Create();
            InitializeComponent();
            CargarEstados();
            CargarMarcas();
            CargarModelo(ModeloID);
        }

        public void CargarEstados()
        {
            cboEstado.Items.AddRange(dbContext.EstadosModelo.ToArray());
        }

        public void CargarMarcas()
        {
            cboMarca.Items.AddRange(dbContext.Marcas.ToArray());
        }

        public void CargarModelo(int ModeloID)
        {
            var Modelo = dbContext.Modelos.Find(ModeloID);
            if (Modelo == null)
                return;

            txtIdentificador.Text = Modelo.ID.ToString();
            txtDescripcion.Text = Modelo.Descripcion;
            cboEstado.SelectedItem = Modelo.Estado;
            cboMarca.SelectedItem = Modelo.Marca;
        }

        public bool Validar()
        {
            if (cboEstado.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un Estado");
                return false;
            }

            if (cboMarca.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una Marca");
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Ingrese una descripcion");
                return false;
            }


            return true;
        }

        private void EditarModelo_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }

            var modelo = dbContext.Modelos.Find(int.Parse(txtIdentificador.Text));
            modelo.Descripcion = txtDescripcion.Text;
            modelo.EstadoID = ((EstadoModelo)cboEstado.SelectedItem).ID;
            dbContext.SaveChanges();
            OnModeloActualizado(this, new EditarModeloEventArgs() { Modelo = modelo });
            this.Close();
        }
    }
    public class EditarModeloEventArgs : EventArgs
    {
        public Modelo Modelo { get; set; }
    }
}
