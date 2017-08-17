using Fiap.Exemplo2.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo2.Web.MVC.Controllers
{
    public class UsuarioController : Controller
    {
       //Abrir a página de cadastro
       [HttpGet]
        public ActionResult Cadastro()
        {
            return View();
        }

        //Rcebr as infomações do formulaio
        [HttpPost]
        public ActionResult Cadastro(Usuario usuario)
        {
            TempData["msg"] = "Usuáio cadastrado!";
            ViewBag.mensagem = "Funciona!";
                    //Nome da pagina e model
            return View("sucesso",usuario);
        }

    }
}