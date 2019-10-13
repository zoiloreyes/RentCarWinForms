namespace RentCar.Forms.RentaDevolucion
{
    partial class NuevaRenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaRenta));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeleccionarVehiculo = new System.Windows.Forms.Button();
            this.txtVehiculo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSeleccionarCliente = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSeleccionarEmpleado = new System.Windows.Forms.Button();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSeleccionarInspeccion = new System.Windows.Forms.Button();
            this.txtInspeccion = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.dtpFechaRenta = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.nupMonto = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nupDias = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevaInspeccion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nueva Renta";
            // 
            // btnSeleccionarVehiculo
            // 
            this.btnSeleccionarVehiculo.Location = new System.Drawing.Point(226, 68);
            this.btnSeleccionarVehiculo.Name = "btnSeleccionarVehiculo";
            this.btnSeleccionarVehiculo.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionarVehiculo.TabIndex = 77;
            this.btnSeleccionarVehiculo.Text = "Seleccionar";
            this.btnSeleccionarVehiculo.UseVisualStyleBackColor = true;
            this.btnSeleccionarVehiculo.Click += new System.EventHandler(this.BtnSeleccionarVehiculo_Click);
            // 
            // txtVehiculo
            // 
            this.txtVehiculo.Enabled = false;
            this.txtVehiculo.Location = new System.Drawing.Point(18, 68);
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.Size = new System.Drawing.Size(202, 20);
            this.txtVehiculo.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "Vehículo";
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(717, 71);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionarCliente.TabIndex = 80;
            this.btnSeleccionarCliente.Text = "Seleccionar";
            this.btnSeleccionarCliente.UseVisualStyleBackColor = true;
            this.btnSeleccionarCliente.Click += new System.EventHandler(this.BtnSeleccionarCliente_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(453, 71);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(258, 20);
            this.txtCliente.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Cliente";
            // 
            // btnSeleccionarEmpleado
            // 
            this.btnSeleccionarEmpleado.Location = new System.Drawing.Point(226, 126);
            this.btnSeleccionarEmpleado.Name = "btnSeleccionarEmpleado";
            this.btnSeleccionarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionarEmpleado.TabIndex = 83;
            this.btnSeleccionarEmpleado.Text = "Seleccionar";
            this.btnSeleccionarEmpleado.UseVisualStyleBackColor = true;
            this.btnSeleccionarEmpleado.Click += new System.EventHandler(this.BtnSeleccionarEmpleado_Click);
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Enabled = false;
            this.txtEmpleado.Location = new System.Drawing.Point(18, 126);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(202, 20);
            this.txtEmpleado.TabIndex = 82;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 81;
            this.label6.Text = "Empleado";
            // 
            // btnSeleccionarInspeccion
            // 
            this.btnSeleccionarInspeccion.Location = new System.Drawing.Point(646, 126);
            this.btnSeleccionarInspeccion.Name = "btnSeleccionarInspeccion";
            this.btnSeleccionarInspeccion.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionarInspeccion.TabIndex = 86;
            this.btnSeleccionarInspeccion.Text = "Seleccionar";
            this.btnSeleccionarInspeccion.UseVisualStyleBackColor = true;
            this.btnSeleccionarInspeccion.Click += new System.EventHandler(this.BtnSeleccionarInspeccion_Click);
            // 
            // txtInspeccion
            // 
            this.txtInspeccion.Enabled = false;
            this.txtInspeccion.Location = new System.Drawing.Point(453, 126);
            this.txtInspeccion.Name = "txtInspeccion";
            this.txtInspeccion.Size = new System.Drawing.Size(187, 20);
            this.txtInspeccion.TabIndex = 85;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(450, 110);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(109, 13);
            this.label.TabIndex = 84;
            this.label.Text = "Inspección Vinculada";
            // 
            // dtpFechaRenta
            // 
            this.dtpFechaRenta.Location = new System.Drawing.Point(18, 188);
            this.dtpFechaRenta.Name = "dtpFechaRenta";
            this.dtpFechaRenta.Size = new System.Drawing.Size(283, 20);
            this.dtpFechaRenta.TabIndex = 89;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 88;
            this.label5.Text = "Fecha";
            // 
            // nupMonto
            // 
            this.nupMonto.DecimalPlaces = 2;
            this.nupMonto.Location = new System.Drawing.Point(452, 188);
            this.nupMonto.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.nupMonto.Name = "nupMonto";
            this.nupMonto.Size = new System.Drawing.Size(340, 20);
            this.nupMonto.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 92;
            this.label3.Text = "Monto x Día";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(18, 309);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(774, 81);
            this.txtComentario.TabIndex = 93;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 94;
            this.label7.Text = "Comentario";
            // 
            // nupDias
            // 
            this.nupDias.Location = new System.Drawing.Point(18, 244);
            this.nupDias.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nupDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupDias.Name = "nupDias";
            this.nupDias.Size = new System.Drawing.Size(283, 20);
            this.nupDias.TabIndex = 95;
            this.nupDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 96;
            this.label8.Text = "Cantidad de días";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(717, 415);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 97;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnNuevaInspeccion
            // 
            this.btnNuevaInspeccion.Image = global::RentCar.Properties.Resources.Webp_net_resizeimage__1_;
            this.btnNuevaInspeccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaInspeccion.Location = new System.Drawing.Point(728, 126);
            this.btnNuevaInspeccion.Name = "btnNuevaInspeccion";
            this.btnNuevaInspeccion.Size = new System.Drawing.Size(64, 23);
            this.btnNuevaInspeccion.TabIndex = 87;
            this.btnNuevaInspeccion.Text = "Nueva";
            this.btnNuevaInspeccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevaInspeccion.UseVisualStyleBackColor = true;
            this.btnNuevaInspeccion.Click += new System.EventHandler(this.BtnNuevaInspeccion_Click);
            // 
            // NuevaRenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nupDias);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nupMonto);
            this.Controls.Add(this.dtpFechaRenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNuevaInspeccion);
            this.Controls.Add(this.btnSeleccionarInspeccion);
            this.Controls.Add(this.txtInspeccion);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnSeleccionarEmpleado);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSeleccionarCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSeleccionarVehiculo);
            this.Controls.Add(this.txtVehiculo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NuevaRenta";
            this.Text = "Registrar Renta";
            this.Load += new System.EventHandler(this.NuevaRenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeleccionarVehiculo;
        private System.Windows.Forms.TextBox txtVehiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSeleccionarCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSeleccionarEmpleado;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSeleccionarInspeccion;
        private System.Windows.Forms.TextBox txtInspeccion;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnNuevaInspeccion;
        private System.Windows.Forms.DateTimePicker dtpFechaRenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nupMonto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nupDias;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGuardar;
    }
}