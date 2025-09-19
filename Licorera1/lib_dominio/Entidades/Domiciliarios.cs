using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Domiciliarios
    {
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Cedula { get; set; }
        public string? Tipo { get; set; }
        public int VehiculoId { get; set; }
        [ForeignKey("VehiculoId")]
        public Vehiculos? _Vehiculo { get; set; }
    }
}
