using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Clientes
    {
        [Key]
        public int Id { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? Telefono { get; set; }
        public string? Cedula { get; set; }
        public int DireccionId { get; set; }
        [ForeignKey("DireccionId")]
        public Direcciones? _Direccion { get; set; }
    }
}
