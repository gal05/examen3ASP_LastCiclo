using examen3Ventas2019.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace examen3Ventas2019.Controllers
{
    public class Problema3Controller : Controller
    {
        // GET: Problema3
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Resultado3()
        {
            Bonificacion3 bon = new Bonificacion3();
            bon.Categoria = Convert.ToDouble(Request.Form["txtcategoria"]);
            bon.NdeHijos = Convert.ToInt32(Request.Form["txtnhijos"]);
            bon.CondicionLab = Convert.ToString(Request.Form["txtcondicion"]);
            return View(bon);
        }


    }
}