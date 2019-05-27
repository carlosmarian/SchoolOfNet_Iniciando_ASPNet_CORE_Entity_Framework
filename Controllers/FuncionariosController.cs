using System;
using System.Linq;
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
        public IActionResult Index(){
            //Obtendo a lista de funcionarios
            var funcionarios = database.Funcionarios.ToList();

            //Passando os atributos para a view
            return View(funcionarios);
        }

        [HttpPost]
        public IActionResult Salvar(Funcionario funcionario){
            //Solicita a adição do item;
            database.Funcionarios.Add(funcionario);
            //Confirma a adição.
            database.SaveChanges();

            //Após salvar vai para a index.
            return RedirectToAction("Index");
        }
    }
}