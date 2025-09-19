using System.ComponentModel.DataAnnotations;

namespace lib_dominio.Entidades
{
    public class Departamentos
    {
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }
    }
}
