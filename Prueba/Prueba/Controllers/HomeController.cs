
using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prueba.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult ListaSucursal()
        {
            try
            {
                SucursalModel model = new SucursalModel();
                var resultado = model.listaSucursal();
                return View(resultado);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        
    }
}