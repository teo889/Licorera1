using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Direcciones
    {
        [Key]
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public int DepartamentoId { get; set; }
        [ForeignKey("DepartamentoId")]
        public Departamentos? _Departamento { get; set; }
        public int MunicipioId { get; set; }
        [ForeignKey("MunicipioId")]
        public Municipios? _Municipio { get; set; }
    }
}
