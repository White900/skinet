using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }

        //Questa property servirà per creare la tabella dei prodotti
        public DbSet<Product> Products { get; set; }
    }
}
