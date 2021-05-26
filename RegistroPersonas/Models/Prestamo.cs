﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPersonas.Models
{
    public class Prestamo
    {
        [Key]
        public int PrestamoId { get; set; }

        [Required(ErrorMessage = "Ingrese una fecha")]
        public DateTime Fecha { get; set; } = DateTime.Now;

        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "Ingrese una persona")]
        public int PersonaId { get; set; }

        public String Concepto { get; set; }

        [RegularExpression(@"^[1-9]\d*.\d*?$", ErrorMessage = "Ingrese un monto válido")]
        public float Monto { get; set; }

        [Required(ErrorMessage = "Ingrese un balance")]
        public float Balance { get; set; }
    }
}
