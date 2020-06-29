using Microsoft.EntityFrameworkCore;
using Models;
namespace Repositories{
    public class Context : DbContext
    {
        public DbSet<AutonomoModels> Autonomos {get; set;}
        public DbSet<EmpreendedorMEIModels> Empreendedores {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder options){
            options.UseMySql("Server=localhost; User Id=root;Database=Worknow");
        }
    }
}