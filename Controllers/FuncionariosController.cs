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

        public IActionResult Editar(int id){
            //OBS: o parametro ID vem do que foi definido l� no Startus.sc no padr�o de rota, que tem o ID como optional

            //Busca o primeiro registro com o mesmo ID do recebido como par�metro.
            Funcionario funcionario = database.Funcionarios.First(registro => registro.Id == id);

            return View("Cadastrar", funcionario);
        }

        public IActionResult Deletar(int id){

            //Busca o primeiro registro com o mesmo ID do recebido como par�metro.
            Funcionario funcionario = database.Funcionarios.First(registro => registro.Id == id);

            database.Funcionarios.Remove(funcionario);

            //Confirma a remo��o
            database.SaveChanges();
            //Ap�s DELETAR vai para a index.
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Salvar(Funcionario funcionario){
            if(funcionario.Id == 0){
                //Solicita a adi��o do item;
                database.Funcionarios.Add(funcionario);
            }else{
                Funcionario funcionarioDoBanco = database.Funcionarios.First(registro => registro.Id == funcionario.Id);
                funcionarioDoBanco.Nome = funcionario.Nome;
                funcionarioDoBanco.Salario = funcionario.Salario;
                funcionarioDoBanco.Cpf = funcionario.Cpf;

            }

            //Confirma a adi��o/edi��o.
            database.SaveChanges();

            //Ap�s salvar vai para a index.
            return RedirectToAction("Index");
        }
    }
}