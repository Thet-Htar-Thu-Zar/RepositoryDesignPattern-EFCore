using Microsoft.EntityFrameworkCore;
using RepositoryDesignPattern_EFCoreCRUD.Models;

namespace RepositoryDesignPattern_EFCoreCRUD.DbService
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) 
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
