using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SegundaEvaluacion.Models
{
    public class Product
    {
        public int id { get; set; }

        [Required]
        public int idStore { get; set; }

        [Required]
        public float price { get; set; }

        [Required]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser mayor a 50 caracteres.")]
        public string name { get; set; }

        [Required]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser mayor a 50 caracteres.")]
        public string description { get; set; }

        [Required]
        public int stock { get; set; }
    }
}