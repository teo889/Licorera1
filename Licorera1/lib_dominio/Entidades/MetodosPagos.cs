﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class MetodosPagos
    {
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }
    }
}
