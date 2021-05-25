using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPersonas.Models
{
    public class Persona
    {
        [Key]
        public int PersonaId { get; set; }
        [Required(ErrorMessage = "Ingrese un nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Ingrese la telefono")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Ingrese un telefono válido")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "Ingrese la cédula")]
        [RegularExpression(@"^\b\d{3}-\d{7}-\d$", ErrorMessage = "Ingrese una cédula válida")]
        public string Cedula { get; set; }
        [Required(ErrorMessage = "Ingrese una dirección")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Ingrese una fecha")]
        public DateTime Fecha { get; set; } = DateTime.Now;
    }



}
