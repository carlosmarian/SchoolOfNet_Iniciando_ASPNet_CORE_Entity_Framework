using System;
using Microsoft.AspNetCore.Mvc;
using NetCOREEntityFramework.Models;
using NetCOREEntityFramework.Database;

namespace NetCOREEntityFramework.Controllers
{
    public class FuncionariosController : Controller
    {
        private readonly ApplicationDBContext database;

        public FuncionariosController(ApplicationDBContext database){
            this.database = database;
        }

        public IActionResult Cadastrar(){
            return View();
        }

        [HttpPost]
        public IActionResult Salvar(Funcionario funcionario){
            //Solicita a adi��o do item;
            database.Funcionarios.Add(funcionario);
            //Confirma a adi��o.
            database.SaveChanges();
            return Content("Funcion�rio salvo");
        }
    }
}