using Microsoft.EntityFrameworkCore;

namespace Repositories{
    public class Context : DbContext
    {
        //public DbSet<Cadastrar> Cadastrar {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder options){
            options.UseMySql("Server=localhost; User Id=root;Database=Worknow");
        }
    }
}