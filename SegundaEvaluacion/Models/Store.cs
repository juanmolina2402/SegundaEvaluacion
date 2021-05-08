using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SegundaEvaluacion.Models
{
    public class Store
    {
        public int id { get; set; }

        [Required]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser mayor a 50 caracteres.")]
        public string addressStore { get; set; }

        [Required]
        public bool typeStore { get; set; }

        [Required]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser mayor a 50 caracteres.")]
        public string description { get; set; }
    }
}