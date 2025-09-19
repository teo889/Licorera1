using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Municipios
    {
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public int DepartamentoId { get; set; }
        [ForeignKey("DepartamentoId")]
        public Departamentos? _Departamento { get; set; }
    }
}
