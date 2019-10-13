namespace RentCar.Forms.Inspección
{
    partial class NuevaInspeccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaInspeccion));
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVehiculo = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRalladuras = new System.Windows.Forms.CheckBox();
            this.cbCristal = new System.Windows.Forms.CheckBox();
            this.cbTieneGato = new System.Windows.Forms.CheckBox();
            this.cbGomaRepuesto = new System.Windows.Forms.CheckBox();
            this.cbGomaDD = new System.Windows.Forms.CheckBox();
            this.cbGomaTD = new System.Windows.Forms.CheckBox();
            this.cbGomaTI = new System.Windows.Forms.CheckBox();
            this.cbGomaDI = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cboCombustible = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSeleccionarVehiculo = new System.Windows.Forms.Button();
            this.btnSeleccionarCliente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSeleccionarEmpleado = new System.Windows.Forms.Button();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaInspeccion = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 31);
            this.label1.TabIndex = 49;
            this.label1.Text = "Inspección";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(567, 515);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 64;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Vehículo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Cliente";
            // 
            // txtVehiculo
            // 
            this.txtVehiculo.Enabled = false;
            this.txtVehiculo.Location = new System.Drawing.Point(16, 30);
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.Size = new System.Drawing.Size(202, 20);
            this.txtVehiculo.TabIndex = 69;
            this.txtVehiculo.TextChanged += new System.EventHandler(this.TxtVehiculo_TextChanged);
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(367, 30);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(187, 20);
            this.txtCliente.TabIndex = 70;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbRalladuras);
            this.groupBox1.Controls.Add(this.cbCristal);
            this.groupBox1.Controls.Add(this.cbTieneGato);
            this.groupBox1.Controls.Add(this.cbGomaRepuesto);
            this.groupBox1.Controls.Add(this.cbGomaDD);
            this.groupBox1.Controls.Add(this.cbGomaTD);
            this.groupBox1.Controls.Add(this.cbGomaTI);
            this.groupBox1.Controls.Add(this.cbGomaDI);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 284);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de verificacion";
            // 
            // cbRalladuras
            // 
            this.cbRalladuras.AutoSize = true;
            this.cbRalladuras.Location = new System.Drawing.Point(337, 252);
            this.cbRalladuras.Name = "cbRalladuras";
            this.cbRalladuras.Size = new System.Drawing.Size(101, 17);
            this.cbRalladuras.TabIndex = 11;
            this.cbRalladuras.Text = "Tiene ralladuras";
            this.cbRalladuras.UseVisualStyleBackColor = true;
            // 
            // cbCristal
            // 
            this.cbCristal.AutoSize = true;
            this.cbCristal.Location = new System.Drawing.Point(337, 186);
            this.cbCristal.Name = "cbCristal";
            this.cbCristal.Size = new System.Drawing.Size(144, 17);
            this.cbCristal.TabIndex = 10;
            this.cbCristal.Text = "Tiene roturas en el cristal";
            this.cbCristal.UseVisualStyleBackColor = true;
            // 
            // cbTieneGato
            // 
            this.cbTieneGato.AutoSize = true;
            this.cbTieneGato.Location = new System.Drawing.Point(337, 220);
            this.cbTieneGato.Name = "cbTieneGato";
            this.cbTieneGato.Size = new System.Drawing.Size(79, 17);
            this.cbTieneGato.TabIndex = 8;
            this.cbTieneGato.Text = "Tiene Gato";
            this.cbTieneGato.UseVisualStyleBackColor = true;
            // 
            // cbGomaRepuesto
            // 
            this.cbGomaRepuesto.AutoSize = true;
            this.cbGomaRepuesto.Location = new System.Drawing.Point(337, 152);
            this.cbGomaRepuesto.Name = "cbGomaRepuesto";
            this.cbGomaRepuesto.Size = new System.Drawing.Size(136, 17);
            this.cbGomaRepuesto.TabIndex = 7;
            this.cbGomaRepuesto.Text = "Neumático de repuesto";
            this.cbGomaRepuesto.UseVisualStyleBackColor = true;
            this.cbGomaRepuesto.CheckedChanged += new System.EventHandler(this.CheckBox4_CheckedChanged);
            // 
            // cbGomaDD
            // 
            this.cbGomaDD.AutoSize = true;
            this.cbGomaDD.Location = new System.Drawing.Point(337, 53);
            this.cbGomaDD.Name = "cbGomaDD";
            this.cbGomaDD.Size = new System.Drawing.Size(166, 17);
            this.cbGomaDD.TabIndex = 6;
            this.cbGomaDD.Text = "Neumático delantero derecho";
            this.cbGomaDD.UseVisualStyleBackColor = true;
            this.cbGomaDD.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // cbGomaTD
            // 
            this.cbGomaTD.AutoSize = true;
            this.cbGomaTD.Location = new System.Drawing.Point(337, 119);
            this.cbGomaTD.Name = "cbGomaTD";
            this.cbGomaTD.Size = new System.Drawing.Size(154, 17);
            this.cbGomaTD.TabIndex = 5;
            this.cbGomaTD.Text = "Neumático trasero derecho";
            this.cbGomaTD.UseVisualStyleBackColor = true;
            // 
            // cbGomaTI
            // 
            this.cbGomaTI.AutoSize = true;
            this.cbGomaTI.Location = new System.Drawing.Point(337, 87);
            this.cbGomaTI.Name = "cbGomaTI";
            this.cbGomaTI.Size = new System.Drawing.Size(160, 17);
            this.cbGomaTI.TabIndex = 4;
            this.cbGomaTI.Text = "Neumático trasero izquierdo ";
            this.cbGomaTI.UseVisualStyleBackColor = true;
            // 
            // cbGomaDI
            // 
            this.cbGomaDI.AutoSize = true;
            this.cbGomaDI.Location = new System.Drawing.Point(337, 19);
            this.cbGomaDI.Name = "cbGomaDI";
            this.cbGomaDI.Size = new System.Drawing.Size(163, 17);
            this.cbGomaDI.TabIndex = 3;
            this.cbGomaDI.Text = "Neumático delantero izquiero";
            this.cbGomaDI.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RentCar.Properties.Resources.CarSideFlipped;
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 152);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(302, 117);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RentCar.Properties.Resources.CarSide;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(302, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // cboCombustible
            // 
            this.cboCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCombustible.FormattingEnabled = true;
            this.cboCombustible.Location = new System.Drawing.Point(18, 166);
            this.cboCombustible.Name = "cboCombustible";
            this.cboCombustible.Size = new System.Drawing.Size(281, 21);
            this.cboCombustible.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Cantidad de Combustible";
            // 
            // btnSeleccionarVehiculo
            // 
            this.btnSeleccionarVehiculo.Location = new System.Drawing.Point(224, 30);
            this.btnSeleccionarVehiculo.Name = "btnSeleccionarVehiculo";
            this.btnSeleccionarVehiculo.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionarVehiculo.TabIndex = 74;
            this.btnSeleccionarVehiculo.Text = "Seleccionar";
            this.btnSeleccionarVehiculo.UseVisualStyleBackColor = true;
            this.btnSeleccionarVehiculo.Click += new System.EventHandler(this.BtnSeleccionarVehiculo_Click);
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(560, 30);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionarCliente.TabIndex = 75;
            this.btnSeleccionarCliente.Text = "Seleccionar";
            this.btnSeleccionarCliente.UseVisualStyleBackColor = true;
            this.btnSeleccionarCliente.Click += new System.EventHandler(this.BtnSeleccionarCliente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 76;
            this.label5.Text = "Fecha";
            // 
            // btnSeleccionarEmpleado
            // 
            this.btnSeleccionarEmpleado.Location = new System.Drawing.Point(224, 85);
            this.btnSeleccionarEmpleado.Name = "btnSeleccionarEmpleado";
            this.btnSeleccionarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionarEmpleado.TabIndex = 79;
            this.btnSeleccionarEmpleado.Text = "Seleccionar";
            this.btnSeleccionarEmpleado.UseVisualStyleBackColor = true;
            this.btnSeleccionarEmpleado.Click += new System.EventHandler(this.BtnSeleccionarEmpleado_Click);
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Enabled = false;
            this.txtEmpleado.Location = new System.Drawing.Point(16, 85);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(202, 20);
            this.txtEmpleado.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 77;
            this.label6.Text = "Empleado";
            // 
            // dtpFechaInspeccion
            // 
            this.dtpFechaInspeccion.Location = new System.Drawing.Point(367, 167);
            this.dtpFechaInspeccion.Name = "dtpFechaInspeccion";
            this.dtpFechaInspeccion.Size = new System.Drawing.Size(268, 20);
            this.dtpFechaInspeccion.TabIndex = 80;
            // 
            // NuevaInspeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 553);
            this.Controls.Add(this.dtpFechaInspeccion);
            this.Controls.Add(this.btnSeleccionarEmpleado);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSeleccionarCliente);
            this.Controls.Add(this.btnSeleccionarVehiculo);
            this.Controls.Add(this.cboCombustible);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtVehiculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NuevaInspeccion";
            this.Text = "Nueva Inspección";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVehiculo;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox cbGomaRepuesto;
        private System.Windows.Forms.CheckBox cbGomaDD;
        private System.Windows.Forms.CheckBox cbGomaTD;
        private System.Windows.Forms.CheckBox cbGomaTI;
        private System.Windows.Forms.CheckBox cbGomaDI;
        private System.Windows.Forms.CheckBox cbCristal;
        private System.Windows.Forms.CheckBox cbTieneGato;
        private System.Windows.Forms.ComboBox cboCombustible;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbRalladuras;
        private System.Windows.Forms.Button btnSeleccionarVehiculo;
        private System.Windows.Forms.Button btnSeleccionarCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSeleccionarEmpleado;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaInspeccion;
    }
}