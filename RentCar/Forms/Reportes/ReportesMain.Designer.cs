namespace RentCar.Forms.Reportes
{
    partial class ReportesMain
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportesMain));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.rentCarMenuStrip1 = new RentCar.Shared.RentCarMenuStrip();
            this.lblFechaMinima = new System.Windows.Forms.Label();
            this.dtpFechaMinima = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaMaxima = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.cboEmpleados = new System.Windows.Forms.ComboBox();
            this.cboTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rvRentas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btlLimpiar = new System.Windows.Forms.Button();
            this.rentaDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rentaDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "Reporte de Renta";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegresar.Location = new System.Drawing.Point(997, 28);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(87, 29);
            this.btnRegresar.TabIndex = 44;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // rentCarMenuStrip1
            // 
            this.rentCarMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.rentCarMenuStrip1.Name = "rentCarMenuStrip1";
            this.rentCarMenuStrip1.Size = new System.Drawing.Size(1096, 24);
            this.rentCarMenuStrip1.TabIndex = 45;
            this.rentCarMenuStrip1.Text = "rentCarMenuStrip1";
            // 
            // lblFechaMinima
            // 
            this.lblFechaMinima.AutoSize = true;
            this.lblFechaMinima.Location = new System.Drawing.Point(14, 63);
            this.lblFechaMinima.Name = "lblFechaMinima";
            this.lblFechaMinima.Size = new System.Drawing.Size(73, 13);
            this.lblFechaMinima.TabIndex = 47;
            this.lblFechaMinima.Text = "Fecha Minima";
            // 
            // dtpFechaMinima
            // 
            this.dtpFechaMinima.Location = new System.Drawing.Point(17, 79);
            this.dtpFechaMinima.Name = "dtpFechaMinima";
            this.dtpFechaMinima.Size = new System.Drawing.Size(170, 20);
            this.dtpFechaMinima.TabIndex = 49;
            this.dtpFechaMinima.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFechaMinima.ValueChanged += new System.EventHandler(this.dtpFechaMinima_ValueChanged);
            // 
            // dtpFechaMaxima
            // 
            this.dtpFechaMaxima.Location = new System.Drawing.Point(208, 79);
            this.dtpFechaMaxima.Name = "dtpFechaMaxima";
            this.dtpFechaMaxima.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaMaxima.TabIndex = 51;
            this.dtpFechaMaxima.Value = new System.DateTime(2121, 2, 27, 0, 0, 0, 0);
            this.dtpFechaMaxima.ValueChanged += new System.EventHandler(this.dtpFechaMaxima_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Fecha Máxima";
            // 
            // cboClientes
            // 
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(424, 79);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(207, 21);
            this.cboClientes.TabIndex = 52;
            this.cboClientes.SelectedIndexChanged += new System.EventHandler(this.cboClientes_SelectedIndexChanged);
            // 
            // cboEmpleados
            // 
            this.cboEmpleados.FormattingEnabled = true;
            this.cboEmpleados.Location = new System.Drawing.Point(656, 79);
            this.cboEmpleados.Name = "cboEmpleados";
            this.cboEmpleados.Size = new System.Drawing.Size(194, 21);
            this.cboEmpleados.TabIndex = 53;
            this.cboEmpleados.SelectedIndexChanged += new System.EventHandler(this.cboEmpleados_SelectedIndexChanged);
            // 
            // cboTipoVehiculo
            // 
            this.cboTipoVehiculo.FormattingEnabled = true;
            this.cboTipoVehiculo.Location = new System.Drawing.Point(879, 78);
            this.cboTipoVehiculo.Name = "cboTipoVehiculo";
            this.cboTipoVehiculo.Size = new System.Drawing.Size(194, 21);
            this.cboTipoVehiculo.TabIndex = 54;
            this.cboTipoVehiculo.SelectedIndexChanged += new System.EventHandler(this.cboTipoCombustible_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(653, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Empleado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(876, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "TipoVehiculo";
            // 
            // rvRentas
            // 
            this.rvRentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource2.Name = "DSRenta";
            reportDataSource2.Value = this.rentaDtoBindingSource;
            this.rvRentas.LocalReport.DataSources.Add(reportDataSource1);
            this.rvRentas.LocalReport.DataSources.Add(reportDataSource2);
            this.rvRentas.LocalReport.ReportEmbeddedResource = "RentCar.Forms.Reportes.Rentas.rdlc";
            this.rvRentas.Location = new System.Drawing.Point(17, 106);
            this.rvRentas.Name = "rvRentas";
            this.rvRentas.Size = new System.Drawing.Size(1056, 432);
            this.rvRentas.TabIndex = 59;
            // 
            // btlLimpiar
            // 
            this.btlLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btlLimpiar.Location = new System.Drawing.Point(904, 27);
            this.btlLimpiar.Name = "btlLimpiar";
            this.btlLimpiar.Size = new System.Drawing.Size(87, 29);
            this.btlLimpiar.TabIndex = 60;
            this.btlLimpiar.Text = "Limpiar";
            this.btlLimpiar.UseVisualStyleBackColor = true;
            this.btlLimpiar.Click += new System.EventHandler(this.btlLimpiar_Click);
            // 
            // rentaDtoBindingSource
            // 
            this.rentaDtoBindingSource.DataSource = typeof(RentCar.Models.RentaDto);
            // 
            // ReportesMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 534);
            this.Controls.Add(this.btlLimpiar);
            this.Controls.Add(this.rvRentas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboTipoVehiculo);
            this.Controls.Add(this.cboEmpleados);
            this.Controls.Add(this.cboClientes);
            this.Controls.Add(this.dtpFechaMaxima);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaMinima);
            this.Controls.Add(this.lblFechaMinima);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rentCarMenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.rentCarMenuStrip1;
            this.Name = "ReportesMain";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.ReportesMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentaDtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegresar;
        private Shared.RentCarMenuStrip rentCarMenuStrip1;
        private System.Windows.Forms.Label lblFechaMinima;
        private System.Windows.Forms.DateTimePicker dtpFechaMinima;
        private System.Windows.Forms.DateTimePicker dtpFechaMaxima;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.ComboBox cboEmpleados;
        private System.Windows.Forms.ComboBox cboTipoVehiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Microsoft.Reporting.WinForms.ReportViewer rvRentas;
        private System.Windows.Forms.Button btlLimpiar;
        private System.Windows.Forms.BindingSource rentaDtoBindingSource;
    }
}