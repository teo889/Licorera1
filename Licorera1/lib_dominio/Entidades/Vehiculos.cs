using System.ComponentModel.DataAnnotations;

namespace lib_dominio.Entidades
{
    public class Vehiculos
    {
        [Key]
        public int Id { get; set; }
        public string? Placa { get; set; }
        public string? Tipo { get; set; }
        public string? Descripcion { get; set; }
    }
}
