using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentCar.Shared;

namespace RentCar.UserControls
{
    public partial class LoggedUser : UserControl
    {
        public LoggedUser()
        {
            InitializeComponent();
            lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TimerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
        }

        private void LoggedUser_Load(object sender, EventArgs e)
        {
            if(GlobalAccess.Usuario != null)
            {
                timerHora.Start();
                lblNombre.Text = $"{GlobalAccess.Usuario.Nombre} {GlobalAccess.Usuario.Apellido}";
            }
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            GlobalAccess.BaseAccesForm.Show();
            (this.Parent as Form).Close();
        }
    }
}
