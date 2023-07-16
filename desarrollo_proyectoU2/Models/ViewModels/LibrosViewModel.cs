using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace desarrollo_proyectoU2.Models.ViewModels
{
    public class LibrosViewModel
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Título")]
        public string titulo { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Autor")]
        public string autor { get; set; }

        [Required]
        [Display(Name = "Año de Publicación")]
        [RegularExpression(@"^\d{4}$", ErrorMessage = "El año de publicación debe ser un número entero de 4 dígitos.")]
        public int anio_publicacion { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Categoría")]
        public string categoria { get; set; }

    }
}