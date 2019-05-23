using Microsoft.EntityFrameworkCore;
using NetCOREEntityFramework.Models;

namespace NetCOREEntityFramework.Database
{
    public class ApplicationDBContext : DbContext
    {

        //Criar atributos para mapear as classe de banco.
        public DbSet<Funcionario> Funcionarios {get;set;}

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options){}

    }
}