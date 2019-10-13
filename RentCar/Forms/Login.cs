using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using RentCar.DAL;
using RentCar.Models;
using RentCar.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace RentCar.Forms
{
    public partial class Login : Form
    {
        private RentCarContext dbContext;
        private UserManager<Usuario> manager;
        private System.Timers.Timer Timer;
        public Login()
        {
            InitializeComponent();
            dbContext = RentCarContext.Create();
            manager = new UserManager<Usuario>(new UserStore<Usuario>(dbContext));
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        
        private bool Valido()
        {
            var usuario = txtUsuario.Text;
            var contrasena = txtContrasena.Text;

            if (String.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show("Usuario inválido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (String.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Contraseña inválida", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if(manager.Find(usuario, contrasena) == null)
            {
                MessageBox.Show("Credenciales inválidas", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!Valido())
                return;
            var usuario = txtUsuario.Text;
            var contrasena = txtContrasena.Text;

            GlobalAccess.Usuario = manager.Find(usuario, contrasena);
            var menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            GlobalAccess.BaseAccesForm = this;
            this.Hide();
            this.initTimer();
        }

        private void initTimer()
        {
            Timer = new System.Timers.Timer();
            Timer.Elapsed += new ElapsedEventHandler(TmrPantallasAbiertas_Tick);
            Timer.Interval += 5000;
            Timer.Enabled = true;
        }

        private void TmrPantallasAbiertas_Tick(object sender, EventArgs e)
        {
            if(Application.OpenForms.Count < 2 && !this.Visible)
            {
                Application.Exit();
            }
        }

        private void Login_Shown(object sender, EventArgs e)
        {

        }

        private void Login_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                txtUsuario.Text = "";
                txtContrasena.Text = "";
            }
        }
    }
}
