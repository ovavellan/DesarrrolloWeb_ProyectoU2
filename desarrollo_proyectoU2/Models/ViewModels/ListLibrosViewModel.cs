using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace desarrollo_proyectoU2.Models.ViewModels
{
    public class ListLibrosViewModel
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
        public int anio_publicacion { get; set; }
        public string categoria { get; set; }
    }
}