using System;
using Microsoft.AspNetCore.Mvc;
using NetCOREEntityFramework.Models;

namespace NetCOREEntityFramework.Controllers
{
    public class FuncionariosController : Controller
    {
        public IActionResult Cadastrar(){
            return View();
        }

        [HttpPost]
        public IActionResult Salvar(Funcionario funcionario){
            return Content("OK"+ funcionario.ToString());
        }
    }
}