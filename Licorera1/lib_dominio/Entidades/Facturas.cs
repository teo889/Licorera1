using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Facturas
    {
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Iva { get; set; }
        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public Clientes? _Cliente { get; set; }
        public int MetodoPagoId { get; set; }
        [ForeignKey("MetodoPagoId")]
        public MetodosPagos? _MetodoPago { get; set; }
        public int? PromocionId { get; set; }
        [ForeignKey("PromocionId")]
        public Promociones? _Promocion { get; set; }
    }
}
