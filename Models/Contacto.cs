using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace apptienda.Models
{
    public class Contacto
    {
        [NotNull]
        public string? Nombre { get; set; }
        [NotNull]
        public string? Email { get; set; } 
        [NotNull]  
        public string? Mensaje { get; set; }     
    }
}