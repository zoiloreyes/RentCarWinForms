namespace RentCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CantidadCombustible",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Cedula = c.String(),
                        TarjetaCredito = c.String(),
                        LimiteCredito = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TipoPersonaID = c.Int(nullable: false),
                        EstadoID = c.Int(nullable: false),
                        Telefono = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.EstadoCliente", t => t.EstadoID, cascadeDelete: true)
                .ForeignKey("dbo.TipoPersona", t => t.TipoPersonaID, cascadeDelete: true)
                .Index(t => t.TipoPersonaID)
                .Index(t => t.EstadoID);
            
            CreateTable(
                "dbo.EstadoCliente",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TipoPersona",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Empleado",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Cedula = c.String(),
                        TandaLaboralID = c.Int(nullable: false),
                        PorcComision = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FechaIngreso = c.DateTime(nullable: false),
                        EstadoID = c.Int(nullable: false),
                        UsuarioID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.EstadoEmpleado", t => t.EstadoID, cascadeDelete: true)
                .ForeignKey("dbo.TandaLaboral", t => t.TandaLaboralID, cascadeDelete: true)
                .ForeignKey("dbo.Usuario", t => t.UsuarioID)
                .Index(t => t.TandaLaboralID)
                .Index(t => t.EstadoID)
                .Index(t => t.UsuarioID);
            
            CreateTable(
                "dbo.EstadoEmpleado",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TandaLaboral",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Nombre = c.String(nullable: false, maxLength: 300),
                        Apellido = c.String(nullable: false, maxLength: 300),
                        Email = c.String(maxLength: 256),
                        EmailConfirmado = c.Boolean(nullable: false),
                        HashContrasena = c.String(),
                        SecurityStamp = c.String(),
                        Telefono = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccesosFallidos = c.Int(nullable: false),
                        NombreUsuario = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.NombreUsuario, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.UsuarioClaim",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuario", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.UsuarioLogin",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.Usuario", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.UsuarioRol",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.Usuario", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Rol", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.EstadoInspeccion",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.EstadoMarca",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.EstadoModelo",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.EstadoRenta_Devolucion",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.EstadoTipoCombustible",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.EstadoTipoVehiculo",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.EstadoVehiculo",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Inspeccion",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        VehiculoID = c.Int(nullable: false),
                        ClienteID = c.Int(nullable: false),
                        TieneRalladuras = c.Boolean(nullable: false),
                        CantidadCombustibleID = c.Int(nullable: false),
                        TieneGomaRepuesta = c.Boolean(nullable: false),
                        TieneGato = c.Boolean(nullable: false),
                        TieneRoturasCristal = c.Boolean(nullable: false),
                        EstadoGoma1 = c.Boolean(nullable: false),
                        EstadoGoma2 = c.Boolean(nullable: false),
                        EstadoGoma3 = c.Boolean(nullable: false),
                        EstadoGoma4 = c.Boolean(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        EmpleadoResponsableID = c.Int(nullable: false),
                        EstadoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CantidadCombustible", t => t.CantidadCombustibleID, cascadeDelete: true)
                .ForeignKey("dbo.Cliente", t => t.ClienteID, cascadeDelete: true)
                .ForeignKey("dbo.Empleado", t => t.EmpleadoResponsableID, cascadeDelete: true)
                .ForeignKey("dbo.EstadoInspeccion", t => t.EstadoID, cascadeDelete: true)
                .ForeignKey("dbo.Vehiculo", t => t.VehiculoID, cascadeDelete: true)
                .Index(t => t.VehiculoID)
                .Index(t => t.ClienteID)
                .Index(t => t.CantidadCombustibleID)
                .Index(t => t.EmpleadoResponsableID)
                .Index(t => t.EstadoID);
            
            CreateTable(
                "dbo.Renta_Devolucion",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EmpleadoID = c.Int(nullable: false),
                        VehiculoID = c.Int(nullable: false),
                        ClienteID = c.Int(nullable: false),
                        InspeccionID = c.Int(nullable: false),
                        FechaRenta = c.DateTime(nullable: false),
                        FechaDevolucion = c.DateTime(),
                        MontoXDia = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CantidadDias = c.Int(nullable: false),
                        Comentario = c.String(),
                        EstadoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cliente", t => t.ClienteID, cascadeDelete: true)
                .ForeignKey("dbo.Empleado", t => t.EmpleadoID, cascadeDelete: true)
                .ForeignKey("dbo.EstadoRenta_Devolucion", t => t.EstadoID, cascadeDelete: true)
                .ForeignKey("dbo.Inspeccion", t => t.InspeccionID)
                .ForeignKey("dbo.Vehiculo", t => t.VehiculoID, cascadeDelete: true)
                .Index(t => t.EmpleadoID)
                .Index(t => t.VehiculoID)
                .Index(t => t.ClienteID)
                .Index(t => t.InspeccionID)
                .Index(t => t.EstadoID);
            
            CreateTable(
                "dbo.Vehiculo",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        NumChasis = c.String(),
                        NumMotor = c.String(),
                        NumPlaca = c.String(),
                        TipoVehiculoID = c.Int(nullable: false),
                        MarcaID = c.Int(nullable: false),
                        ModeloID = c.Int(nullable: false),
                        TipoCombustibleID = c.Int(nullable: false),
                        EstadoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.EstadoVehiculo", t => t.EstadoID, cascadeDelete: true)
                .ForeignKey("dbo.Marca", t => t.MarcaID, cascadeDelete: true)
                .ForeignKey("dbo.Modelo", t => t.ModeloID, cascadeDelete: true)
                .ForeignKey("dbo.TipoCombustible", t => t.TipoCombustibleID, cascadeDelete: true)
                .ForeignKey("dbo.TipoVehiculo", t => t.TipoVehiculoID, cascadeDelete: true)
                .Index(t => t.TipoVehiculoID)
                .Index(t => t.MarcaID)
                .Index(t => t.ModeloID)
                .Index(t => t.TipoCombustibleID)
                .Index(t => t.EstadoID);
            
            CreateTable(
                "dbo.Marca",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        EstadoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.EstadoMarca", t => t.EstadoID, cascadeDelete: true)
                .Index(t => t.EstadoID);
            
            CreateTable(
                "dbo.Modelo",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MarcaID = c.Int(nullable: false),
                        Descripcion = c.String(),
                        EstadoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.EstadoModelo", t => t.EstadoID, cascadeDelete: true)
                .ForeignKey("dbo.Marca", t => t.MarcaID)
                .Index(t => t.MarcaID)
                .Index(t => t.EstadoID);
            
            CreateTable(
                "dbo.TipoCombustible",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        EstadoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.EstadoTipoCombustible", t => t.EstadoID, cascadeDelete: true)
                .Index(t => t.EstadoID);
            
            CreateTable(
                "dbo.TipoVehiculo",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        EstadoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.EstadoTipoVehiculo", t => t.EstadoID, cascadeDelete: true)
                .Index(t => t.EstadoID);
            
            CreateTable(
                "dbo.Rol",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UsuarioRol", "RoleId", "dbo.Rol");
            DropForeignKey("dbo.Inspeccion", "VehiculoID", "dbo.Vehiculo");
            DropForeignKey("dbo.Renta_Devolucion", "VehiculoID", "dbo.Vehiculo");
            DropForeignKey("dbo.Vehiculo", "TipoVehiculoID", "dbo.TipoVehiculo");
            DropForeignKey("dbo.TipoVehiculo", "EstadoID", "dbo.EstadoTipoVehiculo");
            DropForeignKey("dbo.Vehiculo", "TipoCombustibleID", "dbo.TipoCombustible");
            DropForeignKey("dbo.TipoCombustible", "EstadoID", "dbo.EstadoTipoCombustible");
            DropForeignKey("dbo.Vehiculo", "ModeloID", "dbo.Modelo");
            DropForeignKey("dbo.Vehiculo", "MarcaID", "dbo.Marca");
            DropForeignKey("dbo.Modelo", "MarcaID", "dbo.Marca");
            DropForeignKey("dbo.Modelo", "EstadoID", "dbo.EstadoModelo");
            DropForeignKey("dbo.Marca", "EstadoID", "dbo.EstadoMarca");
            DropForeignKey("dbo.Vehiculo", "EstadoID", "dbo.EstadoVehiculo");
            DropForeignKey("dbo.Renta_Devolucion", "InspeccionID", "dbo.Inspeccion");
            DropForeignKey("dbo.Renta_Devolucion", "EstadoID", "dbo.EstadoRenta_Devolucion");
            DropForeignKey("dbo.Renta_Devolucion", "EmpleadoID", "dbo.Empleado");
            DropForeignKey("dbo.Renta_Devolucion", "ClienteID", "dbo.Cliente");
            DropForeignKey("dbo.Inspeccion", "EstadoID", "dbo.EstadoInspeccion");
            DropForeignKey("dbo.Inspeccion", "EmpleadoResponsableID", "dbo.Empleado");
            DropForeignKey("dbo.Inspeccion", "ClienteID", "dbo.Cliente");
            DropForeignKey("dbo.Inspeccion", "CantidadCombustibleID", "dbo.CantidadCombustible");
            DropForeignKey("dbo.Empleado", "UsuarioID", "dbo.Usuario");
            DropForeignKey("dbo.UsuarioRol", "UserId", "dbo.Usuario");
            DropForeignKey("dbo.UsuarioLogin", "UserId", "dbo.Usuario");
            DropForeignKey("dbo.UsuarioClaim", "UserId", "dbo.Usuario");
            DropForeignKey("dbo.Empleado", "TandaLaboralID", "dbo.TandaLaboral");
            DropForeignKey("dbo.Empleado", "EstadoID", "dbo.EstadoEmpleado");
            DropForeignKey("dbo.Cliente", "TipoPersonaID", "dbo.TipoPersona");
            DropForeignKey("dbo.Cliente", "EstadoID", "dbo.EstadoCliente");
            DropIndex("dbo.Rol", "RoleNameIndex");
            DropIndex("dbo.TipoVehiculo", new[] { "EstadoID" });
            DropIndex("dbo.TipoCombustible", new[] { "EstadoID" });
            DropIndex("dbo.Modelo", new[] { "EstadoID" });
            DropIndex("dbo.Modelo", new[] { "MarcaID" });
            DropIndex("dbo.Marca", new[] { "EstadoID" });
            DropIndex("dbo.Vehiculo", new[] { "EstadoID" });
            DropIndex("dbo.Vehiculo", new[] { "TipoCombustibleID" });
            DropIndex("dbo.Vehiculo", new[] { "ModeloID" });
            DropIndex("dbo.Vehiculo", new[] { "MarcaID" });
            DropIndex("dbo.Vehiculo", new[] { "TipoVehiculoID" });
            DropIndex("dbo.Renta_Devolucion", new[] { "EstadoID" });
            DropIndex("dbo.Renta_Devolucion", new[] { "InspeccionID" });
            DropIndex("dbo.Renta_Devolucion", new[] { "ClienteID" });
            DropIndex("dbo.Renta_Devolucion", new[] { "VehiculoID" });
            DropIndex("dbo.Renta_Devolucion", new[] { "EmpleadoID" });
            DropIndex("dbo.Inspeccion", new[] { "EstadoID" });
            DropIndex("dbo.Inspeccion", new[] { "EmpleadoResponsableID" });
            DropIndex("dbo.Inspeccion", new[] { "CantidadCombustibleID" });
            DropIndex("dbo.Inspeccion", new[] { "ClienteID" });
            DropIndex("dbo.Inspeccion", new[] { "VehiculoID" });
            DropIndex("dbo.UsuarioRol", new[] { "RoleId" });
            DropIndex("dbo.UsuarioRol", new[] { "UserId" });
            DropIndex("dbo.UsuarioLogin", new[] { "UserId" });
            DropIndex("dbo.UsuarioClaim", new[] { "UserId" });
            DropIndex("dbo.Usuario", "UserNameIndex");
            DropIndex("dbo.Empleado", new[] { "UsuarioID" });
            DropIndex("dbo.Empleado", new[] { "EstadoID" });
            DropIndex("dbo.Empleado", new[] { "TandaLaboralID" });
            DropIndex("dbo.Cliente", new[] { "EstadoID" });
            DropIndex("dbo.Cliente", new[] { "TipoPersonaID" });
            DropTable("dbo.Rol");
            DropTable("dbo.TipoVehiculo");
            DropTable("dbo.TipoCombustible");
            DropTable("dbo.Modelo");
            DropTable("dbo.Marca");
            DropTable("dbo.Vehiculo");
            DropTable("dbo.Renta_Devolucion");
            DropTable("dbo.Inspeccion");
            DropTable("dbo.EstadoVehiculo");
            DropTable("dbo.EstadoTipoVehiculo");
            DropTable("dbo.EstadoTipoCombustible");
            DropTable("dbo.EstadoRenta_Devolucion");
            DropTable("dbo.EstadoModelo");
            DropTable("dbo.EstadoMarca");
            DropTable("dbo.EstadoInspeccion");
            DropTable("dbo.UsuarioRol");
            DropTable("dbo.UsuarioLogin");
            DropTable("dbo.UsuarioClaim");
            DropTable("dbo.Usuario");
            DropTable("dbo.TandaLaboral");
            DropTable("dbo.EstadoEmpleado");
            DropTable("dbo.Empleado");
            DropTable("dbo.TipoPersona");
            DropTable("dbo.EstadoCliente");
            DropTable("dbo.Cliente");
            DropTable("dbo.CantidadCombustible");
        }
    }
}
