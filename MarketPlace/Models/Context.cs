using Microsoft.EntityFrameworkCore;

namespace MarketPlace.Models
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options) :base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
