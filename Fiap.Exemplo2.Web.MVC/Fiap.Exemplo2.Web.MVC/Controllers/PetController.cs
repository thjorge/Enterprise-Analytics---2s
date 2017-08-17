using Fiap.Exemplo2.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo2.Web.MVC.Controllers
{
   
    public class PetController : Controller
    {

        //Simular o banco de dados
        private static List<Pet> _banco = new List<Pet>();


        [HttpGet]
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(Pet pet)
        {
            //Grava no banco
            _banco.Add(pet);
            //Mensagem de sucesso
            TempData["msg"] = "Cadastrado!";
            ViewBag.mensagem = "Gravado!";
            return View();
        }

        [HttpGet]
        public ActionResult Listar()
        {
            //Passar os pets cadastrados a view
            return View(_banco );
        }


    }
}