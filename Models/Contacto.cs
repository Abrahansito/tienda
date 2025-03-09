using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace apptienda.Models
{
    public class Contacto
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? Nombre { get; set; }
        [NotNull]
        public string? Email { get; set; } 
        [NotNull]  
        public string? Mensaje { get; set; }     
    }
}