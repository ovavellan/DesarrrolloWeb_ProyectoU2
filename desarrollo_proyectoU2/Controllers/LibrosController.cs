using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using desarrollo_proyectoU2.Models;
using desarrollo_proyectoU2.Models.ViewModels;

namespace desarrollo_proyectoU2.Controllers
{
    public class LibrosController : Controller
    {
        // GET: Libros
        public ActionResult Index()
        {
            List<ListLibrosViewModel> lst;
            using (bibliotecaEntities db = new bibliotecaEntities())
            {
                lst = (from c in db.Libros
                       select new ListLibrosViewModel
                       {
                           id = c.id,
                           titulo = c.titulo,
                           autor = c.autor,
                           anio_publicacion = c.anio_publicacion,
                           categoria = c.categoria
                       }).ToList();
            }
            return View(lst);
        }

        public ActionResult Nuevo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Nuevo(ListLibrosViewModel libroModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (bibliotecaEntities db = new bibliotecaEntities())
                    {
                        var oLibro = new Libros();
                        oLibro.titulo = libroModel.titulo;
                        oLibro.autor = libroModel.autor;
                        oLibro.anio_publicacion = libroModel.anio_publicacion;
                        oLibro.categoria = libroModel.categoria;

                        db.Libros.Add(oLibro);
                        db.SaveChanges();
                    }
                    return RedirectToAction("~/Libros/Index"); 
                }

                return View(libroModel); 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
