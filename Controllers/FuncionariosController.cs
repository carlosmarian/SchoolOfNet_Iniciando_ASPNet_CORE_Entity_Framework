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
            //OBS: o parametro ID vem do que foi definido lá no Startus.sc no padrão de rota, que tem o ID como optional

            //Busca o primeiro registro com o mesmo ID do recebido como parâmetro.
            Funcionario funcionario = database.Funcionarios.First(registro => registro.Id == id);

            return View("Cadastrar", funcionario);
        }

        public IActionResult Deletar(int id){

            //Busca o primeiro registro com o mesmo ID do recebido como parâmetro.
            Funcionario funcionario = database.Funcionarios.First(registro => registro.Id == id);

            database.Funcionarios.Remove(funcionario);

            //Confirma a remoção
            database.SaveChanges();
            //Após DELETAR vai para a index.
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Salvar(Funcionario funcionario){
            if(funcionario.Id == 0){
                //Solicita a adição do item;
                database.Funcionarios.Add(funcionario);
            }else{
                Funcionario funcionarioDoBanco = database.Funcionarios.First(registro => registro.Id == funcionario.Id);
                funcionarioDoBanco.Nome = funcionario.Nome;
                funcionarioDoBanco.Salario = funcionario.Salario;
                funcionarioDoBanco.Cpf = funcionario.Cpf;

            }

            //Confirma a adição/edição.
            database.SaveChanges();

            //Após salvar vai para a index.
            return RedirectToAction("Index");
        }
    }
}