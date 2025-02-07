﻿using CarvedRock.Api.Data;

namespace CarvedRock.Api.Repository;

public interface ICarvedRockRepository
{
    Task<List<Product>> GetAllProductsAsync();
    Task<Product?> GetProductByIdAsync(int productId);
    Task<Product> AddProductAsync(Product product);
    Task UpdateProductAsync(Product product);
    Task RemoveProductAsync(int productIdToRemove);
    Task<Category?> GetCategoryByIdAsync(int categoryId);
    Task<List<Category>> GetAllCategoriesAsync();
}

