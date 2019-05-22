using Microsoft.EntityFrameworkCore;

namespace NetCOREEntityFramework.Database
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options){}
    }
}