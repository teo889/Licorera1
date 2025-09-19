using lib_dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;


namespace lib_repositorios.Interfaces
{
    public interface IConexion
    {
        string? StringConexion { get; set; }

        DbSet<MetodosPagos>? MetodosPagos { get; set; }
        DbSet<Proveedores>? Proveedores { get; set; }
        DbSet<Empleados>? Empleados { get; set; }
        DbSet<Departamentos>? Departamentos { get; set; }
        DbSet<Municipios>? Municipios { get; set; }
        DbSet<Promociones>? Promociones { get; set; }
        DbSet<Vehiculos>? Vehiculos { get; set; }
        DbSet<Tipolicores>? Tipolicores { get; set; }
        DbSet<Domiciliarios>? Domiciliarios { get; set; }
        DbSet<Direcciones>? Direcciones { get; set; }
        DbSet<Clientes>? Clientes { get; set; }
        DbSet<Productos>? Productos { get; set; }
        DbSet<Facturas>? Facturas { get; set; }
        DbSet<Domicilios>? Domicilios { get; set; }
        DbSet<DetalleFacturas>? DetalleFacturas { get; set; }

        EntityEntry<T> Entry<T>(T entity) where T : class;
        int SaveChanges();
    }

}

