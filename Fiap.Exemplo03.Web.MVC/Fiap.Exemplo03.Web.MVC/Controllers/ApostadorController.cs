using Fiap.Exemplo03.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo03.Web.MVC.Controllers
{
    public class ApostadorController : Controller
    {

        LoteriaContext context = new LoteriaContext();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Apostador apostador)
        {
            context.Apostadores.Add(apostador);            context.SaveChanges();
            return RedirectToAction("Cadastrar");
        }

    }
}