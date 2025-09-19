using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Domicilios
    {
        [Key]
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public Clientes? _Cliente { get; set; }
        public int DomiciliarioId { get; set; }
        [ForeignKey("DomiciliarioId")]
        public Domiciliarios? _Domiciliario { get; set; }
        public int FacturaId { get; set; }
        [ForeignKey("FacturaId")]
        public Facturas? _Factura { get; set; }
    }
}

