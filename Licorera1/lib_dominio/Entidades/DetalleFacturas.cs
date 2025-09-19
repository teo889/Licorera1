using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class DetalleFacturas
    {
        [Key]
        public int Id { get; set; }
        public int FacturaId { get; set; }
        [ForeignKey("FacturaId")]
        public Facturas? _Factura { get; set; }
        public int ProductoId { get; set; }
        [ForeignKey("ProductoId")]
        public Productos? _Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
    }
}
