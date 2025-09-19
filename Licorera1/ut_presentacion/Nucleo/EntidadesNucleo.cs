using lib_dominio.Entidades;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ut_presentacion.Nucleo
{
    public class EntidadesNucleo
    {
        public static MetodosPagos? MetodosPagos()
        {
            var entidad = new MetodosPagos();
            entidad.Nombre = "Efectivo";
            return entidad;
        }

        public static Proveedores? Proveedores()
        {
            var entidad = new Proveedores();
            entidad.Nombre = "Distribuidora Bogotá";
            entidad.Telefono = "3101234567";
            return entidad;
        }

        public static Empleados? Empleados()
        {
            var entidad = new Empleados();
            entidad.Nombre = "Juan";
            entidad.Apellido = "Pérez";
            entidad.Cedula = "1012345678";
            entidad.Telefono = "3001112233";
            return entidad;
        }

        public static Departamentos? Departamentos()
        {
            var entidad = new Departamentos();
            entidad.Nombre = "Bogotá D.C.";
            return entidad;
        }

        public static Municipios? Municipios()
        {
            var entidad = new Municipios();
            entidad.Nombre = "Bogotá";
            entidad.DepartamentoId = 1;
            return entidad;
        }

        public static Promociones? Promociones()
        {
            var entidad = new Promociones();
            entidad.Nombre = "Descuento 10%";
            entidad.Descripcion = "Descuento del 10% en compras superiores a $100.000";
            return entidad;
        }

        public static Vehiculos? Vehiculos()
        {
            var entidad = new Vehiculos();
            entidad.Placa = "ABC123";
            entidad.Tipo = "Moto";
            entidad.Descripcion = "Moto Yamaha azul";
            return entidad;
        }

        public static Tipolicores? Tipolicores()
        {
            var entidad = new Tipolicores();
            entidad.Nombre = "Whisky";
            entidad.Descripcion = "Whisky importado y nacional";
            return entidad;
        }

        public static Domiciliarios? Domiciliarios()
        {
            var entidad = new Domiciliarios();
            entidad.Nombre = "Pedro Morales";
            entidad.Cedula = "1012345671";
            entidad.Tipo = "Motorizado";
            entidad.VehiculoId = 1;
            return entidad;
        }

        public static Direcciones? Direcciones()
        {
            var entidad = new Direcciones();
            entidad.Descripcion = "Calle 10 # 20-30";
            entidad.DepartamentoId = 1;
            entidad.MunicipioId = 1;
            return entidad;
        }

        public static Clientes? Clientes()
        {
            var entidad = new Clientes();
            entidad.Nombres = "Andrés";
            entidad.Apellidos = "García";
            entidad.Telefono = "3101234567";
            entidad.Cedula = "1012345670";
            entidad.DireccionId = 1;
            return entidad;
        }

        public static Productos? Productos()
        {
            var entidad = new Productos();
            entidad.Nombre = "Whisky Chivas";
            entidad.PrecioUnitario = 120000m;
            entidad.ProveedorId = 1;
            entidad.TipoLicorId = 1;
            return entidad;
        }

        public static Facturas? Facturas()
        {
            var entidad = new Facturas();
            entidad.Fecha = DateTime.Parse("2025-09-18");
            entidad.SubTotal = 120000m;
            entidad.Iva = 21600m;
            entidad.ClienteId = 1;
            entidad.MetodoPagoId = 1;
            entidad.PromocionId = 1;
            return entidad;
        }

        public static Domicilios? Domicilios()
        {
            var entidad = new Domicilios();
            entidad.Descripcion = "Entrega rápida";
            entidad.FechaEntrega = DateTime.Parse("2025-09-18");
            entidad.ClienteId = 1;
            entidad.DomiciliarioId = 1;
            entidad.FacturaId = 1;
            return entidad;
        }

        public static DetalleFacturas? DetalleFacturas()
        {
            var entidad = new DetalleFacturas();
            entidad.FacturaId = 1;
            entidad.ProductoId = 1;
            entidad.Cantidad = 1;
            entidad.Total = 120000m;
            return entidad;
        }
    }
}
