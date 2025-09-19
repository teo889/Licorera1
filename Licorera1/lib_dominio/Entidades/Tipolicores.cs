using System.ComponentModel.DataAnnotations;

namespace lib_dominio.Entidades
{
    public class Tipolicores
    {
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
    }
}
