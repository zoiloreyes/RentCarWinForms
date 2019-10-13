using RentCar.Forms;
using RentCar.Forms.Clientes;
using RentCar.Forms.Empleados;
using RentCar.Forms.Inspección;
using RentCar.Forms.Marcas;
using RentCar.Forms.Modelos;
using RentCar.Forms.RentaDevolucion;
using RentCar.Forms.Reportes;
using RentCar.Forms.TiposCombustible;
using RentCar.Forms.Vehículos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar.Shared
{
    public class RentCarMenuStrip: MenuStrip
    {
        public RentCarMenuStrip() : base()
        {
            var itemVehiculos = new ToolStripMenuItem("Vehiculos");
            itemVehiculos.Click += (s, ev) =>
            {
                var vehiculos = new VehiculosMain();
                if (this.Parent is Form)
                {
                    (this.Parent as Form).Close();
                }
                vehiculos.Show();
            };
            this.Items.Add(itemVehiculos);

            var itemEmpleados = new ToolStripMenuItem("Empleados");
            itemEmpleados.Click += (s, ev) =>
            {
                var empleados = new EmpleadosMain();
                if (this.Parent is Form)
                {
                    (this.Parent as Form).Close();
                }
                empleados.Show();
            };
            this.Items.Add(itemEmpleados);

            var itemClientes  = new ToolStripMenuItem("Clientes");
            itemClientes.Click += (s, ev) =>
            {
                var clientes = new ClientesMain();
                if (this.Parent is Form)
                {
                    (this.Parent as Form).Close();
                }
                clientes.Show();
            };
            this.Items.Add(itemClientes);

            var itemTipos = new ToolStripMenuItem("Tipos de vehiculos");
            itemTipos.Click += (s, ev) =>
            {
                var tipoVehi = new TiposDeVehiculo();
                if (this.Parent is Form)
                {
                    (this.Parent as Form).Close();
                }
                tipoVehi.Show();
            };
            this.Items.Add(itemTipos);

            var itemMarcas= new ToolStripMenuItem("Marcas");
            itemMarcas.Click += (s, ev) =>
            {
                var marcas = new MarcasMain();
                if (this.Parent is Form)
                {
                    (this.Parent as Form).Close();
                }
                marcas.Show();
            };
            this.Items.Add(itemMarcas);

            var itemModelos = new ToolStripMenuItem("Modelos");
            itemModelos.Click += (s, ev) =>
            {
                var modelos = new ModelosMain();
                if (this.Parent is Form)
                {
                    (this.Parent as Form).Close();
                }
                modelos.Show();
            };
            this.Items.Add(itemModelos);

            var itemTiposCombus = new ToolStripMenuItem("Tipos de Combustibles");
            itemTiposCombus.Click += (s, ev) =>
            {
                var tipoComb = new TiposCombustibleMain();
                if (this.Parent is Form)
                {
                    (this.Parent as Form).Close();
                }
                tipoComb.Show();
            };
            this.Items.Add(itemTiposCombus);

            var itemInspecciones = new ToolStripMenuItem("Inspecciones");
            itemInspecciones.Click += (s, ev) =>
            {
                var inspecciones = new InspeccionesMain();
                if (this.Parent is Form)
                {
                    (this.Parent as Form).Close();
                }
                inspecciones.Show();
            };
            this.Items.Add(itemInspecciones);

            var itemRentas = new ToolStripMenuItem("Rentas");
            itemRentas.Click += (s, ev) =>
            {
                var rentas = new RentasMain();
                if (this.Parent is Form)
                {
                    (this.Parent as Form).Close();
                }
                rentas.Show();
            };
            this.Items.Add(itemRentas);

            var itemReportes= new ToolStripMenuItem("Reportes");
            itemReportes.Click += (s, ev) =>
            {
                var reportes = new ReportesMain();
                if (this.Parent is Form)
                {
                    (this.Parent as Form).Close();
                }
                reportes.Show();
            };
            this.Items.Add(itemReportes);
        }


    }
}
