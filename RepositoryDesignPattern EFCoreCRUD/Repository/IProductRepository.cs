﻿using RepositoryDesignPattern_EFCoreCRUD.Models;

namespace RepositoryDesignPattern_EFCoreCRUD.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProductById(int id);
        Task<Product> CreateProduct(Product product);
        Task<Product> UpdateProduct(Product product);
        Task DeleteProductAsync(int id);
    }
}
