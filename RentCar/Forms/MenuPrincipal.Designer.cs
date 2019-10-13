namespace RentCar.Forms
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.lblTiposVehiculos = new System.Windows.Forms.Label();
            this.gbTiposVehiculos = new System.Windows.Forms.GroupBox();
            this.pbTiposVehiculos = new System.Windows.Forms.PictureBox();
            this.gbMarcas = new System.Windows.Forms.GroupBox();
            this.pbMarcas = new System.Windows.Forms.PictureBox();
            this.lblMarcas = new System.Windows.Forms.Label();
            this.gbModelos = new System.Windows.Forms.GroupBox();
            this.pbModelos = new System.Windows.Forms.PictureBox();
            this.lblModelos = new System.Windows.Forms.Label();
            this.gbTiposCombustible = new System.Windows.Forms.GroupBox();
            this.pbTiposCombustible = new System.Windows.Forms.PictureBox();
            this.lblTiposCombustible = new System.Windows.Forms.Label();
            this.gbClientes = new System.Windows.Forms.GroupBox();
            this.pbCliente = new System.Windows.Forms.PictureBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.gbVehiculos = new System.Windows.Forms.GroupBox();
            this.pbVehiculos = new System.Windows.Forms.PictureBox();
            this.lblVehiculos = new System.Windows.Forms.Label();
            this.gbEmpleados = new System.Windows.Forms.GroupBox();
            this.pbEmpleados = new System.Windows.Forms.PictureBox();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.gbInspeccion = new System.Windows.Forms.GroupBox();
            this.pbInspeccion = new System.Windows.Forms.PictureBox();
            this.lblInspeccion = new System.Windows.Forms.Label();
            this.gbRentas = new System.Windows.Forms.GroupBox();
            this.pbRentas = new System.Windows.Forms.PictureBox();
            this.lblRentas = new System.Windows.Forms.Label();
            this.gbReportes = new System.Windows.Forms.GroupBox();
            this.pbReportes = new System.Windows.Forms.PictureBox();
            this.lblReportes = new System.Windows.Forms.Label();
            this.loggedUser1 = new RentCar.UserControls.LoggedUser();
            this.gbTiposVehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTiposVehiculos)).BeginInit();
            this.gbMarcas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMarcas)).BeginInit();
            this.gbModelos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbModelos)).BeginInit();
            this.gbTiposCombustible.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTiposCombustible)).BeginInit();
            this.gbClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCliente)).BeginInit();
            this.gbVehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVehiculos)).BeginInit();
            this.gbEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpleados)).BeginInit();
            this.gbInspeccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInspeccion)).BeginInit();
            this.gbRentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRentas)).BeginInit();
            this.gbReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTiposVehiculos
            // 
            this.lblTiposVehiculos.AutoSize = true;
            this.lblTiposVehiculos.Location = new System.Drawing.Point(28, 123);
            this.lblTiposVehiculos.Name = "lblTiposVehiculos";
            this.lblTiposVehiculos.Size = new System.Drawing.Size(99, 13);
            this.lblTiposVehiculos.TabIndex = 1;
            this.lblTiposVehiculos.Text = "Tipos de Vehículos";
            // 
            // gbTiposVehiculos
            // 
            this.gbTiposVehiculos.Controls.Add(this.pbTiposVehiculos);
            this.gbTiposVehiculos.Controls.Add(this.lblTiposVehiculos);
            this.gbTiposVehiculos.Location = new System.Drawing.Point(12, 87);
            this.gbTiposVehiculos.Name = "gbTiposVehiculos";
            this.gbTiposVehiculos.Size = new System.Drawing.Size(160, 145);
            this.gbTiposVehiculos.TabIndex = 2;
            this.gbTiposVehiculos.TabStop = false;
            this.gbTiposVehiculos.Enter += new System.EventHandler(this.GbTiposVehiculos_Enter);
            // 
            // pbTiposVehiculos
            // 
            this.pbTiposVehiculos.Image = global::RentCar.Properties.Resources.TipoVehiculo;
            this.pbTiposVehiculos.Location = new System.Drawing.Point(12, 19);
            this.pbTiposVehiculos.Name = "pbTiposVehiculos";
            this.pbTiposVehiculos.Size = new System.Drawing.Size(135, 101);
            this.pbTiposVehiculos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTiposVehiculos.TabIndex = 0;
            this.pbTiposVehiculos.TabStop = false;
            // 
            // gbMarcas
            // 
            this.gbMarcas.Controls.Add(this.pbMarcas);
            this.gbMarcas.Controls.Add(this.lblMarcas);
            this.gbMarcas.Location = new System.Drawing.Point(178, 87);
            this.gbMarcas.Name = "gbMarcas";
            this.gbMarcas.Size = new System.Drawing.Size(160, 145);
            this.gbMarcas.TabIndex = 3;
            this.gbMarcas.TabStop = false;
            // 
            // pbMarcas
            // 
            this.pbMarcas.Image = global::RentCar.Properties.Resources.Marcas;
            this.pbMarcas.Location = new System.Drawing.Point(12, 19);
            this.pbMarcas.Name = "pbMarcas";
            this.pbMarcas.Size = new System.Drawing.Size(135, 101);
            this.pbMarcas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMarcas.TabIndex = 0;
            this.pbMarcas.TabStop = false;
            // 
            // lblMarcas
            // 
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Location = new System.Drawing.Point(56, 123);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(42, 13);
            this.lblMarcas.TabIndex = 1;
            this.lblMarcas.Text = "Marcas";
            // 
            // gbModelos
            // 
            this.gbModelos.Controls.Add(this.pbModelos);
            this.gbModelos.Controls.Add(this.lblModelos);
            this.gbModelos.Location = new System.Drawing.Point(344, 87);
            this.gbModelos.Name = "gbModelos";
            this.gbModelos.Size = new System.Drawing.Size(160, 145);
            this.gbModelos.TabIndex = 3;
            this.gbModelos.TabStop = false;
            // 
            // pbModelos
            // 
            this.pbModelos.Image = global::RentCar.Properties.Resources.Modelos;
            this.pbModelos.Location = new System.Drawing.Point(12, 19);
            this.pbModelos.Name = "pbModelos";
            this.pbModelos.Size = new System.Drawing.Size(135, 101);
            this.pbModelos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbModelos.TabIndex = 0;
            this.pbModelos.TabStop = false;
            // 
            // lblModelos
            // 
            this.lblModelos.AutoSize = true;
            this.lblModelos.Location = new System.Drawing.Point(54, 123);
            this.lblModelos.Name = "lblModelos";
            this.lblModelos.Size = new System.Drawing.Size(47, 13);
            this.lblModelos.TabIndex = 1;
            this.lblModelos.Text = "Modelos";
            // 
            // gbTiposCombustible
            // 
            this.gbTiposCombustible.Controls.Add(this.pbTiposCombustible);
            this.gbTiposCombustible.Controls.Add(this.lblTiposCombustible);
            this.gbTiposCombustible.Location = new System.Drawing.Point(510, 87);
            this.gbTiposCombustible.Name = "gbTiposCombustible";
            this.gbTiposCombustible.Size = new System.Drawing.Size(160, 145);
            this.gbTiposCombustible.TabIndex = 3;
            this.gbTiposCombustible.TabStop = false;
            this.gbTiposCombustible.Enter += new System.EventHandler(this.GbTiposCombustible_Enter);
            // 
            // pbTiposCombustible
            // 
            this.pbTiposCombustible.Image = global::RentCar.Properties.Resources.Combustible;
            this.pbTiposCombustible.Location = new System.Drawing.Point(12, 19);
            this.pbTiposCombustible.Name = "pbTiposCombustible";
            this.pbTiposCombustible.Size = new System.Drawing.Size(135, 101);
            this.pbTiposCombustible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTiposCombustible.TabIndex = 0;
            this.pbTiposCombustible.TabStop = false;
            // 
            // lblTiposCombustible
            // 
            this.lblTiposCombustible.AutoSize = true;
            this.lblTiposCombustible.Location = new System.Drawing.Point(28, 123);
            this.lblTiposCombustible.Name = "lblTiposCombustible";
            this.lblTiposCombustible.Size = new System.Drawing.Size(108, 13);
            this.lblTiposCombustible.TabIndex = 1;
            this.lblTiposCombustible.Text = "Tipos de Combustible";
            // 
            // gbClientes
            // 
            this.gbClientes.Controls.Add(this.pbCliente);
            this.gbClientes.Controls.Add(this.lblCliente);
            this.gbClientes.Location = new System.Drawing.Point(12, 238);
            this.gbClientes.Name = "gbClientes";
            this.gbClientes.Size = new System.Drawing.Size(160, 145);
            this.gbClientes.TabIndex = 3;
            this.gbClientes.TabStop = false;
            this.gbClientes.Enter += new System.EventHandler(this.GbClientes_Enter);
            // 
            // pbCliente
            // 
            this.pbCliente.Image = global::RentCar.Properties.Resources.Clientes;
            this.pbCliente.Location = new System.Drawing.Point(12, 19);
            this.pbCliente.Name = "pbCliente";
            this.pbCliente.Size = new System.Drawing.Size(135, 101);
            this.pbCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCliente.TabIndex = 0;
            this.pbCliente.TabStop = false;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(51, 123);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(44, 13);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Clientes";
            // 
            // gbVehiculos
            // 
            this.gbVehiculos.Controls.Add(this.pbVehiculos);
            this.gbVehiculos.Controls.Add(this.lblVehiculos);
            this.gbVehiculos.Location = new System.Drawing.Point(676, 87);
            this.gbVehiculos.Name = "gbVehiculos";
            this.gbVehiculos.Size = new System.Drawing.Size(160, 145);
            this.gbVehiculos.TabIndex = 4;
            this.gbVehiculos.TabStop = false;
            // 
            // pbVehiculos
            // 
            this.pbVehiculos.Image = global::RentCar.Properties.Resources.Vehiculos;
            this.pbVehiculos.Location = new System.Drawing.Point(12, 19);
            this.pbVehiculos.Name = "pbVehiculos";
            this.pbVehiculos.Size = new System.Drawing.Size(135, 101);
            this.pbVehiculos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVehiculos.TabIndex = 0;
            this.pbVehiculos.TabStop = false;
            // 
            // lblVehiculos
            // 
            this.lblVehiculos.AutoSize = true;
            this.lblVehiculos.Location = new System.Drawing.Point(51, 123);
            this.lblVehiculos.Name = "lblVehiculos";
            this.lblVehiculos.Size = new System.Drawing.Size(55, 13);
            this.lblVehiculos.TabIndex = 1;
            this.lblVehiculos.Text = "Vehículos";
            // 
            // gbEmpleados
            // 
            this.gbEmpleados.Controls.Add(this.pbEmpleados);
            this.gbEmpleados.Controls.Add(this.lblEmpleados);
            this.gbEmpleados.Location = new System.Drawing.Point(178, 238);
            this.gbEmpleados.Name = "gbEmpleados";
            this.gbEmpleados.Size = new System.Drawing.Size(160, 145);
            this.gbEmpleados.TabIndex = 4;
            this.gbEmpleados.TabStop = false;
            // 
            // pbEmpleados
            // 
            this.pbEmpleados.Image = global::RentCar.Properties.Resources.Empleado;
            this.pbEmpleados.Location = new System.Drawing.Point(12, 19);
            this.pbEmpleados.Name = "pbEmpleados";
            this.pbEmpleados.Size = new System.Drawing.Size(135, 101);
            this.pbEmpleados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmpleados.TabIndex = 0;
            this.pbEmpleados.TabStop = false;
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Location = new System.Drawing.Point(39, 123);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(59, 13);
            this.lblEmpleados.TabIndex = 1;
            this.lblEmpleados.Text = "Empleados";
            // 
            // gbInspeccion
            // 
            this.gbInspeccion.Controls.Add(this.pbInspeccion);
            this.gbInspeccion.Controls.Add(this.lblInspeccion);
            this.gbInspeccion.Location = new System.Drawing.Point(344, 238);
            this.gbInspeccion.Name = "gbInspeccion";
            this.gbInspeccion.Size = new System.Drawing.Size(160, 145);
            this.gbInspeccion.TabIndex = 4;
            this.gbInspeccion.TabStop = false;
            // 
            // pbInspeccion
            // 
            this.pbInspeccion.Image = global::RentCar.Properties.Resources.Inspeccion;
            this.pbInspeccion.Location = new System.Drawing.Point(12, 19);
            this.pbInspeccion.Name = "pbInspeccion";
            this.pbInspeccion.Size = new System.Drawing.Size(135, 101);
            this.pbInspeccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInspeccion.TabIndex = 0;
            this.pbInspeccion.TabStop = false;
            // 
            // lblInspeccion
            // 
            this.lblInspeccion.AutoSize = true;
            this.lblInspeccion.Location = new System.Drawing.Point(54, 123);
            this.lblInspeccion.Name = "lblInspeccion";
            this.lblInspeccion.Size = new System.Drawing.Size(59, 13);
            this.lblInspeccion.TabIndex = 1;
            this.lblInspeccion.Text = "Inspección";
            // 
            // gbRentas
            // 
            this.gbRentas.Controls.Add(this.pbRentas);
            this.gbRentas.Controls.Add(this.lblRentas);
            this.gbRentas.Location = new System.Drawing.Point(510, 238);
            this.gbRentas.Name = "gbRentas";
            this.gbRentas.Size = new System.Drawing.Size(160, 145);
            this.gbRentas.TabIndex = 4;
            this.gbRentas.TabStop = false;
            // 
            // pbRentas
            // 
            this.pbRentas.Image = global::RentCar.Properties.Resources.Renta;
            this.pbRentas.Location = new System.Drawing.Point(12, 19);
            this.pbRentas.Name = "pbRentas";
            this.pbRentas.Size = new System.Drawing.Size(135, 101);
            this.pbRentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRentas.TabIndex = 0;
            this.pbRentas.TabStop = false;
            // 
            // lblRentas
            // 
            this.lblRentas.AutoSize = true;
            this.lblRentas.Location = new System.Drawing.Point(19, 123);
            this.lblRentas.Name = "lblRentas";
            this.lblRentas.Size = new System.Drawing.Size(117, 13);
            this.lblRentas.TabIndex = 1;
            this.lblRentas.Text = "Rentas y Devoluciones";
            // 
            // gbReportes
            // 
            this.gbReportes.Controls.Add(this.pbReportes);
            this.gbReportes.Controls.Add(this.lblReportes);
            this.gbReportes.Location = new System.Drawing.Point(676, 238);
            this.gbReportes.Name = "gbReportes";
            this.gbReportes.Size = new System.Drawing.Size(160, 145);
            this.gbReportes.TabIndex = 5;
            this.gbReportes.TabStop = false;
            // 
            // pbReportes
            // 
            this.pbReportes.Image = global::RentCar.Properties.Resources.Reportes;
            this.pbReportes.Location = new System.Drawing.Point(12, 19);
            this.pbReportes.Name = "pbReportes";
            this.pbReportes.Size = new System.Drawing.Size(135, 101);
            this.pbReportes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReportes.TabIndex = 0;
            this.pbReportes.TabStop = false;
            // 
            // lblReportes
            // 
            this.lblReportes.AutoSize = true;
            this.lblReportes.Location = new System.Drawing.Point(51, 123);
            this.lblReportes.Name = "lblReportes";
            this.lblReportes.Size = new System.Drawing.Size(50, 13);
            this.lblReportes.TabIndex = 1;
            this.lblReportes.Text = "Reportes";
            // 
            // loggedUser1
            // 
            this.loggedUser1.Location = new System.Drawing.Point(12, -2);
            this.loggedUser1.Name = "loggedUser1";
            this.loggedUser1.Size = new System.Drawing.Size(824, 83);
            this.loggedUser1.TabIndex = 6;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 394);
            this.Controls.Add(this.loggedUser1);
            this.Controls.Add(this.gbReportes);
            this.Controls.Add(this.gbRentas);
            this.Controls.Add(this.gbInspeccion);
            this.Controls.Add(this.gbEmpleados);
            this.Controls.Add(this.gbVehiculos);
            this.Controls.Add(this.gbClientes);
            this.Controls.Add(this.gbTiposCombustible);
            this.Controls.Add(this.gbModelos);
            this.Controls.Add(this.gbMarcas);
            this.Controls.Add(this.gbTiposVehiculos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.Shown += new System.EventHandler(this.MenuPrincipal_Shown);
            this.gbTiposVehiculos.ResumeLayout(false);
            this.gbTiposVehiculos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTiposVehiculos)).EndInit();
            this.gbMarcas.ResumeLayout(false);
            this.gbMarcas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMarcas)).EndInit();
            this.gbModelos.ResumeLayout(false);
            this.gbModelos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbModelos)).EndInit();
            this.gbTiposCombustible.ResumeLayout(false);
            this.gbTiposCombustible.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTiposCombustible)).EndInit();
            this.gbClientes.ResumeLayout(false);
            this.gbClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCliente)).EndInit();
            this.gbVehiculos.ResumeLayout(false);
            this.gbVehiculos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVehiculos)).EndInit();
            this.gbEmpleados.ResumeLayout(false);
            this.gbEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpleados)).EndInit();
            this.gbInspeccion.ResumeLayout(false);
            this.gbInspeccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInspeccion)).EndInit();
            this.gbRentas.ResumeLayout(false);
            this.gbRentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRentas)).EndInit();
            this.gbReportes.ResumeLayout(false);
            this.gbReportes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTiposVehiculos;
        private System.Windows.Forms.Label lblTiposVehiculos;
        private System.Windows.Forms.GroupBox gbTiposVehiculos;
        private System.Windows.Forms.GroupBox gbMarcas;
        private System.Windows.Forms.PictureBox pbMarcas;
        private System.Windows.Forms.Label lblMarcas;
        private System.Windows.Forms.GroupBox gbModelos;
        private System.Windows.Forms.PictureBox pbModelos;
        private System.Windows.Forms.Label lblModelos;
        private System.Windows.Forms.GroupBox gbTiposCombustible;
        private System.Windows.Forms.PictureBox pbTiposCombustible;
        private System.Windows.Forms.Label lblTiposCombustible;
        private System.Windows.Forms.GroupBox gbClientes;
        private System.Windows.Forms.PictureBox pbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.GroupBox gbVehiculos;
        private System.Windows.Forms.PictureBox pbVehiculos;
        private System.Windows.Forms.Label lblVehiculos;
        private System.Windows.Forms.GroupBox gbEmpleados;
        private System.Windows.Forms.PictureBox pbEmpleados;
        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.GroupBox gbInspeccion;
        private System.Windows.Forms.PictureBox pbInspeccion;
        private System.Windows.Forms.Label lblInspeccion;
        private System.Windows.Forms.GroupBox gbRentas;
        private System.Windows.Forms.PictureBox pbRentas;
        private System.Windows.Forms.Label lblRentas;
        private System.Windows.Forms.GroupBox gbReportes;
        private System.Windows.Forms.PictureBox pbReportes;
        private System.Windows.Forms.Label lblReportes;
        private UserControls.LoggedUser loggedUser1;
    }
}