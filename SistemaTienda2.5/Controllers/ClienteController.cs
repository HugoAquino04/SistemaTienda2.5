using SistemaTienda2._5.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaTienda2._5.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente

        private SistemaTiendaContext _context;

        public ClienteController() 
        {
          _context = new SistemaTiendaContext();

        }
        public ActionResult Index()
        {
            return View(_context.Clientes.ToList());
        }
    }
}