using Microsoft.EntityFrameworkCore;
using RepositoryDesignPattern_EFCoreCRUD.DbService;
using RepositoryDesignPattern_EFCoreCRUD.Models;

namespace RepositoryDesignPattern_EFCoreCRUD.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext appDbContext;

        public ProductRepository(ProductContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<Product> CreateProduct(Product product)
        {
            var result = await appDbContext.Products.AddAsync(product);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await appDbContext.Products.FirstOrDefaultAsync(x => x.ProductId == id);
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await appDbContext.Products.ToListAsync();
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            var result = await appDbContext.Products
                .FirstOrDefaultAsync(x => x.ProductId == product.ProductId);

            if(result != null)
            {
                result.ProductName = product.ProductName;
                result.ProductCategory = product.ProductCategory;
                result.ProductDescription = product.ProductDescription;

                await appDbContext.SaveChangesAsync();

                return result;
            }

            return null;

        }
    }
}
