using examen3Ventas2019.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace examen3Ventas2019.Controllers
{
    public class Problema2Controller : Controller
    {
        // GET: Problema2
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Resultado2()
        {
            Bonificacion2 bono = new Bonificacion2();
            bono.NdeHijos = Convert.ToInt32(Request.Form["txtnhijos"]);
            bono.ImporteTotalMes = Convert.ToDouble(Request.Form["txtimporte"]);           

            return View(bono);
        }
    }
}