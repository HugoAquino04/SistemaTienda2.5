using SistemaTienda2._5.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaTienda2._5.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria

        private SistemaTiendaContext _context;

        public CategoriaController()
        {
            _context = new SistemaTiendaContext();

        }
        public ActionResult Index()
        {
            return View(_context.Categorias.ToList());
        }
    }
}