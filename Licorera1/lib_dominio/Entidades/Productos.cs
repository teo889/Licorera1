using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Productos
    {
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int ProveedorId { get; set; }
        [ForeignKey("ProveedorId")]
        public Proveedores? _Proveedor { get; set; }
        public int TipoLicorId { get; set; }
        [ForeignKey("TipoLicorId")]
        public Tipolicores? _TipoLicor { get; set; }
    }
}
