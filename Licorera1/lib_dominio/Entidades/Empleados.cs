using System.ComponentModel.DataAnnotations;

namespace lib_dominio.Entidades
{
    public class Empleados
    {
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Cedula { get; set; }
        public string? Telefono { get; set; }
    }
}
