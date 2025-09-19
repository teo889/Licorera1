using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lib_repositorios.Implementaciones
{
    public partial class Conexion : DbContext, IConexion
    {
        public string? StringConexion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.StringConexion!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<MetodosPagos>? MetodosPagos { get; set; }
        public DbSet<Proveedores>? Proveedores { get; set; }
        public DbSet<Empleados>? Empleados { get; set; }
        public DbSet<Departamentos>? Departamentos { get; set; }
        public DbSet<Municipios>? Municipios { get; set; }
        public DbSet<Promociones>? Promociones { get; set; }
        public DbSet<Vehiculos>? Vehiculos { get; set; }
        public DbSet<Tipolicores>? Tipolicores { get; set; }
        public DbSet<Domiciliarios>? Domiciliarios { get; set; }
        public DbSet<Direcciones>? Direcciones { get; set; }
        public DbSet<Clientes>? Clientes { get; set; }
        public DbSet<Productos>? Productos { get; set; }
        public DbSet<Facturas>? Facturas { get; set; }
        public DbSet<Domicilios>? Domicilios { get; set; }
        public DbSet<DetalleFacturas>? DetalleFacturas { get; set; }
    }
}