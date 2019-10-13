using Microsoft.AspNet.Identity.EntityFramework;
using RentCar.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.DAL
{
    class RentCarContext : IdentityDbContext<Usuario>
    {
        public DbSet<CantidadCombustible> CantidadesCombustible { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<EstadoCliente> EstadosCliente { get; set; }
        public DbSet<EstadoEmpleado> EstadosEmpleado { get; set; }
        public DbSet<EstadoInspeccion> EstadosInspeccion { get; set; }
        public DbSet<EstadoMarca> EstadosMarca { get; set; }
        public DbSet<EstadoModelo> EstadosModelo { get; set; }
        public DbSet<EstadoRenta_Devolucion> EstadosRenta_Devolucion { get; set; }
        public DbSet<EstadoTipoCombustible> EstadosTipoCombustible { get; set; }
        public DbSet<EstadoTipoVehiculo> EstadosTipoVehiculo { get; set; }
        public DbSet<EstadoVehiculo> EstadosVehiculo { get; set; }
        public DbSet<Inspeccion> Inspecciones { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Renta_Devolucion> Rentas_Devoluciones { get; set; }
        public DbSet<TandaLaboral> TandasLaborales { get; set; }
        public DbSet<TipoCombustible> TiposCombustible { get; set; }
        public DbSet<TipoVehiculo> TiposVehiculo { get; set; }
        public DbSet<TipoPersona> TiposPersona { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public RentCarContext(): base("RentCar", throwIfV1Schema: false)
        {
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Usuario>().Property(d => d.PhoneNumber).HasColumnName("Telefono");
            modelBuilder.Entity<Usuario>().Property(d => d.EmailConfirmed).HasColumnName("EmailConfirmado");
            modelBuilder.Entity<Usuario>().Property(d => d.PasswordHash).HasColumnName("HashContrasena");
            modelBuilder.Entity<Usuario>().Property(d => d.AccessFailedCount).HasColumnName("AccesosFallidos");
            modelBuilder.Entity<Usuario>().Property(d => d.UserName).HasColumnName("NombreUsuario");

            modelBuilder.Entity<IdentityRole>().ToTable("Rol");
            modelBuilder.Entity<IdentityUserRole>().ToTable("UsuarioRol");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("UsuarioClaim");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("UsuarioLogin");

            modelBuilder.Entity<Modelo>()
                .HasRequired(m => m.Marca)
                .WithMany(m => m.Modelos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Renta_Devolucion>()
                .HasRequired(r => r.Inspeccion)
                .WithMany(i => i.Rentas_Devolucions)
                .WillCascadeOnDelete(false);
        }

        public static RentCarContext Create()
        {
            return new RentCarContext();
        }
    }
}
