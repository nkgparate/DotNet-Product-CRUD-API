using ProductCRUDAPI.DTOs;
using ProductCRUDAPI.Models;

namespace ProductCRUDAPI.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllAsync();
        Task<Product?> GetByIdAsync(int id);
        Task<Product> CreateAsync(ProductDTO productDto);
        Task<bool> UpdateAsync(int id, ProductDTO productDto);
        Task<bool> DeleteAsync(int id);
    }
}
