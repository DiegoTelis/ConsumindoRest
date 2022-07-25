using Microsoft.EntityFrameworkCore;
using WebConsumindoRest.Models;

namespace WebConsumindoRest.Data
{
    public class BancoContext: DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
            
        }

        public DbSet<TodoModel> Todos { get; set; }


    }
}
