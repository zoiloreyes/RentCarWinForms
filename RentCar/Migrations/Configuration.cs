namespace RentCar.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using RentCar.DAL;
    using RentCar.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RentCar.DAL.RentCarContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RentCar.DAL.RentCarContext context)
        {

            var manager = new UserManager<Usuario>(new UserStore<Usuario>(new RentCarContext()));

            var usuario = new Usuario()
            {
                UserName = "zoiloreyes",
                Email = "zoiloismaelreyes1@gmail.com",
                EmailConfirmed = true,
                Nombre = "Zoilo",
                Apellido = "Reyes"
            };

            manager.Create(usuario, "scottie5");


            context.EstadosTipoVehiculo.AddRange(new List<EstadoTipoVehiculo>()
            {
                new EstadoTipoVehiculo() {Nombre = "Activo"},
                new EstadoTipoVehiculo() {Nombre = "Inactivo"}
            });

            context.TiposVehiculo.AddRange(new List<TipoVehiculo>()
            {
                new TipoVehiculo() {EstadoID = 1, Descripcion = "Sedán"},
                new TipoVehiculo() {EstadoID = 1, Descripcion = "Compacto"},
                new TipoVehiculo() {EstadoID = 1, Descripcion = "Jeepeta"},
                new TipoVehiculo() {EstadoID = 1, Descripcion = "Camioneta"},
                new TipoVehiculo() {EstadoID = 1, Descripcion = "Coupé/Sport"},
                new TipoVehiculo() {EstadoID = 1, Descripcion = "Autobus"},
                new TipoVehiculo() {EstadoID = 1, Descripcion = "Motor"},
                new TipoVehiculo() {EstadoID = 1, Descripcion = "Camión"}
            });

            context.EstadosMarca.AddRange(new List<EstadoMarca>()
            {
                new EstadoMarca() {Nombre = "Activa"},
                new EstadoMarca() {Nombre = "Inactiva"}
            });


            context.Marcas.AddOrUpdate(
                new Marca() { ID = 1, EstadoID = 1, Descripcion = "Acura" },
                new Marca() { ID = 2, EstadoID = 1, Descripcion = "Airman" },
                new Marca() { ID = 3, EstadoID = 1, Descripcion = "Alfa Romeo" },
                new Marca() { ID = 4, EstadoID = 1, Descripcion = "Astra" },
                new Marca() { ID = 5, EstadoID = 1, Descripcion = "Audi" },
                new Marca() { ID = 6, EstadoID = 1, Descripcion = "Autiny" },
                new Marca() { ID = 7, EstadoID = 1, Descripcion = "Bajaj" },
                new Marca() { ID = 8, EstadoID = 1, Descripcion = "Belshe" },
                new Marca() { ID = 9, EstadoID = 1, Descripcion = "Bentley" },
                new Marca() { ID = 10, EstadoID = 1, Descripcion = "Blued Birt" },
                new Marca() { ID = 11, EstadoID = 1, Descripcion = "BMW" },
                new Marca() { ID = 12, EstadoID = 1, Descripcion = "Bote" },
                new Marca() { ID = 13, EstadoID = 1, Descripcion = "Brilliance" },
                new Marca() { ID = 14, EstadoID = 1, Descripcion = "Buick" },
                new Marca() { ID = 15, EstadoID = 1, Descripcion = "Cadillac" },
                new Marca() { ID = 16, EstadoID = 1, Descripcion = "Chevrolet" },
                new Marca() { ID = 17, EstadoID = 1, Descripcion = "Daihatsu" },
                new Marca() { ID = 18, EstadoID = 1, Descripcion = "Dodge" },
                new Marca() { ID = 19, EstadoID = 1, Descripcion = "Datsun" },
                new Marca() { ID = 20, EstadoID = 1, Descripcion = "Ferrari" },
                new Marca() { ID = 21, EstadoID = 1, Descripcion = "Fiat" },
                new Marca() { ID = 22, EstadoID = 1, Descripcion = "Honda" },
                new Marca() { ID = 22, EstadoID = 1, Descripcion = "Kia" },
                new Marca() { ID = 24, EstadoID = 1, Descripcion = "Land Rover" },
                new Marca() { ID = 25, EstadoID = 1, Descripcion = "Lamborghini" },
                new Marca() { ID = 26, EstadoID = 1, Descripcion = "Lexus" },
                new Marca() { ID = 27, EstadoID = 1, Descripcion = "Hyundai" },
                new Marca() { ID = 28, EstadoID = 1, Descripcion = "Ford" },
                new Marca() { ID = 29, EstadoID = 1, Descripcion = "Toyota" },
                new Marca() { ID = 30, EstadoID = 1, Descripcion = "Volvo" }
            );

            context.Modelos.AddOrUpdate(
                new Modelo() { ID = 1, EstadoID = 1, Descripcion = "Yaris", MarcaID = 29 },
                new Modelo() { ID = 2, EstadoID = 1, Descripcion = "Corolla", MarcaID = 29 },
                new Modelo() { ID = 3, EstadoID = 1, Descripcion = "Prius", MarcaID = 29 },
                new Modelo() { ID = 4, EstadoID = 1, Descripcion = "Camry", MarcaID = 29 },
                new Modelo() { ID = 5, EstadoID = 1, Descripcion = "Avalon", MarcaID = 29 },
                new Modelo() { ID = 7, EstadoID = 1, Descripcion = "Mirai", MarcaID = 29 },
                new Modelo() { ID = 8, EstadoID = 1, Descripcion = "ILX", MarcaID = 1 },
                new Modelo() { ID = 9, EstadoID = 1, Descripcion = "RDX", MarcaID = 1 },
                new Modelo() { ID = 10, EstadoID = 1, Descripcion = "MDX", MarcaID = 1 },
                new Modelo() { ID = 11, EstadoID = 1, Descripcion = "TLX", MarcaID = 1 },
                new Modelo() { ID = 12, EstadoID = 1, Descripcion = "TLX", MarcaID = 2 },
                new Modelo() { ID = 13, EstadoID = 1, Descripcion = "TLX", MarcaID = 2 },
                new Modelo() { ID = 14, EstadoID = 1, Descripcion = "Genesis", MarcaID = 27 },
                new Modelo() { ID = 15, EstadoID = 1, Descripcion = "IONIQ", MarcaID = 27 },
                new Modelo() { ID = 16, EstadoID = 1, Descripcion = "Sonata", MarcaID = 27 }
                );


            context.EstadosTipoCombustible.AddRange(new List<EstadoTipoCombustible>()
            {
                new EstadoTipoCombustible() {Nombre = "Activo"},
                new EstadoTipoCombustible() {Nombre = "Inactivo"}
            });

            context.TiposCombustible.AddRange(new List<TipoCombustible>() {
                new TipoCombustible() { EstadoID = 1, Descripcion = "Gasoil/Diesel"},
                new TipoCombustible() { EstadoID = 1, Descripcion = "Gasolina"},
                new TipoCombustible() { EstadoID = 1, Descripcion = "Gas/GLP"},
                new TipoCombustible() { EstadoID = 1, Descripcion = "Eléctrico/Híbrido"}
            });

            context.EstadosCliente.AddRange(new List<EstadoCliente>()
            {
                new EstadoCliente() { Nombre = "Activo"},
                new EstadoCliente() { Nombre = "Inactivo"},

            });

            context.EstadosEmpleado.AddRange(new List<EstadoEmpleado>()
            {
                new EstadoEmpleado() { Nombre = "Activo"},
                new EstadoEmpleado() { Nombre = "Inactivo"},
            });

            context.EstadosInspeccion.AddRange(new List<EstadoInspeccion>()
            {
                new EstadoInspeccion() {Nombre = "Válida"},
                new EstadoInspeccion() {Nombre = "Inválida"}
            });

            context.EstadosModelo.AddRange(new List<EstadoModelo>()
            {
                new EstadoModelo() {Nombre = "Válido"},
                new EstadoModelo() {Nombre = "Inválido"}
            });

            context.TiposPersona.AddOrUpdate(
                new TipoPersona() { ID = 1, Nombre = "Persona Física" },
                new TipoPersona() { ID = 2, Nombre = "Persona Jurídica" });

            context.EstadosVehiculo.AddRange(new List<EstadoVehiculo>()
            {
                new EstadoVehiculo() {Nombre = "Disponible"},
                new EstadoVehiculo() {Nombre = "Rentado"},
                new EstadoVehiculo() {Nombre = "No Disponible"}
            });

            context.EstadosRenta_Devolucion.AddRange(new List<EstadoRenta_Devolucion>() {
                new EstadoRenta_Devolucion() {Nombre = "Valida"},
                new EstadoRenta_Devolucion() {Nombre = "Inválida"}
            });

            context.TandasLaborales.AddRange(new List<TandaLaboral>()
            {
               new TandaLaboral() {Nombre = "Diurna"},
               new TandaLaboral() {Nombre = "Nocturna"},
            });

            context.CantidadesCombustible.AddRange(new List<CantidadCombustible>()
            {
                new CantidadCombustible() {Nombre = "1/4"},
                new CantidadCombustible() {Nombre = "1/2"},
                new CantidadCombustible() {Nombre = "3/4"},
                new CantidadCombustible() {Nombre = "Lleno"},
            });


            context.Clientes.AddOrUpdate(
                new Cliente() { ID = 1, EstadoID = 1, Nombre = "Carlos Romero Vega", Cedula = "001-1232453-4", LimiteCredito = 100000, TarjetaCredito = "xxx-xxx-xxxx", Telefono = "809-408-89787", TipoPersonaID = 1 },
                new Cliente() { ID = 2, EstadoID = 1, Nombre = "Marcos Serra Flores", Cedula = "001-1239553-4", LimiteCredito = 100000, TarjetaCredito = "xxx-xxx-xxxx", Telefono = "809-258-89787", TipoPersonaID = 1 },
                new Cliente() { ID = 3, EstadoID = 1, Nombre = "Francisco Perez Hidalgo", Cedula = "001-1632453-4", LimiteCredito = 100000, TarjetaCredito = "xxx-xxx-xxxx", Telefono = "809-923-89787", TipoPersonaID = 1 },
                new Cliente() { ID = 4, EstadoID = 1, Nombre = "Hugo Iglesias Gomez", Cedula = "001-1225453-4", LimiteCredito = 100000, TarjetaCredito = "xxx-xxx-xxxx", Telefono = "809-408-4294", TipoPersonaID = 1 },
                new Cliente() { ID = 5, EstadoID = 1, Nombre = "Cristian Hernandez Pastor", Cedula = "001-1288453-4", LimiteCredito = 100000, TarjetaCredito = "xxx-xxx-xxxx", Telefono = "809-408-9482", TipoPersonaID = 1 }
                );


            /*
            context.Empleados.AddOrUpdate(
             new Empleado() { ID = 1, Nombre = "Aaron", Apellido = "Carrasco Carmona", FechaIngreso = new DateTime(2017, 01, 01), Cedula = "001-1232453-4", EstadoID = 1, PorcComision = 10, TandaLaboralID = 1, Usu});*/

        }
    }
}
