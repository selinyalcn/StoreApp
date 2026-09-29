using Microsoft.EntityFrameworkCore;
using StoreApp.Models;

namespace StoreApp
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> options)
        : base(options)
        {
            
        }
    }
}