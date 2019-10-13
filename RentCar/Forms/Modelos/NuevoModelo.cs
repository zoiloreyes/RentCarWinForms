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
    public partial class NuevoModelo : Form
    {
        private RentCarContext dbContext;
        public event EventHandler<NuevoModeloEventArgs> OnNuevoModeloAdded;


        public NuevoModelo()
        {
            dbContext = RentCarContext.Create();
            InitializeComponent();
            CargarMarcas();
        }

        private void CargarMarcas()
        {
            cboMarca.Items.AddRange(dbContext.Marcas.ToArray());
        }

        public bool Validar()
        {
            if (String.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Ingresa una descripción");
                return false;
            }

            if (cboMarca.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una Marca");
                return false;
            }

            return true;
        }



        private void NuevoModelo_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }

            var modelo = new Modelo()
            {
                Descripcion = txtDescripcion.Text,
                EstadoID = (int) ENUM_ESTADO_MODELO.ACTIVO,
                MarcaID = ((Marca)cboMarca.SelectedItem).ID
            };

            dbContext.Modelos.Add(modelo);
            dbContext.SaveChanges();
            OnNuevoModeloAdded(this, new NuevoModeloEventArgs { Modelo = modelo });
            this.Close();
        }
    }

    public class NuevoModeloEventArgs: EventArgs
    {
        public Modelo Modelo { get; set; }
    }
}
