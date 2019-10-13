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

namespace RentCar.Forms.Modelos
{
    public partial class DetalleModelo : Form
    {
        private RentCarContext dbContext;
        public event EventHandler<EditarModeloEventArgs> OnModeloActualizado;
        public event EventHandler<EliminarModeloEventArgs> OnModeloEliminado;
        public Modelo Modelo;

        public DetalleModelo(int ModeloID)
        {
            dbContext = RentCarContext.Create();
            InitializeComponent();
            CargarModelo(ModeloID);
        }

        public void CargarModelo(int ModeloID)
        {
            var modelo = dbContext.Modelos.AsNoTracking().Include(m => m.Estado).Include(m => m.Marca).FirstOrDefault(m => m.ID == ModeloID);
            if (modelo == null)
                return;

            this.Modelo = modelo;

            lblTitulo.Text = $"{Modelo.ID} - {Modelo.Descripcion}";
            lblIdentificador.Text = Modelo.ID.ToString();
            lblDescripcion.Text = Modelo.Descripcion;
            lblEstado.Text = Modelo.Estado?.Nombre;
            lblMarca.Text = Modelo.Marca.Descripcion;
        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var ventana = new EditarModelo(Modelo.ID);
            ventana.OnModeloActualizado += (s, ev) =>
            {
                MessageBox.Show("Modelo Actualizado");
                this.OnModeloActualizado(this, new EditarModeloEventArgs() { Modelo = ev.Modelo });
                this.CargarModelo(ev.Modelo.ID);
            };
            ventana.Show();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            
            var removido = dbContext.Modelos.Remove(Modelo);
            dbContext.SaveChanges();
            OnModeloEliminado(this, new EliminarModeloEventArgs() { Modelo = removido });
            this.Close();
        }

        private void DetalleModelo_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }

    public class EliminarModeloEventArgs : EventArgs
    {
        public Modelo Modelo { get; set; }
    }
}
