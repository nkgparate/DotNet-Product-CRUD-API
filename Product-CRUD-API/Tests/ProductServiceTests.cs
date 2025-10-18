using Xunit;
using ProductCRUDAPI.Services;
using ProductCRUDAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace ProductCRUDAPI.Tests
{
    public class ProductServiceTests
    {
        private readonly AppDbContext _context;
        private readonly ProductService _service;

        public ProductServiceTests()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDb")
                .Options;

            _context = new AppDbContext(options);
            _service = new ProductService(_context);
        }

        [Fact]
        public async Task CreateProduct_ShouldAddProduct()
        {
            var dto = new DTOs.ProductDTO
            {
                Name = "Test Product",
                Description = "Test Desc",
                Price = 100,
                Stock = 10
            };

            var product = await _service.CreateAsync(dto);
            Assert.NotNull(product);
            Assert.Equal("Test Product", product.Name);
        }
    }
}
