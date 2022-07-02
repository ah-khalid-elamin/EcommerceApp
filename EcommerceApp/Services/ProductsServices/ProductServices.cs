using EcommerceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceApp.Services.ProductsServices
{
    public class ProductServices : IProductServices
    {
        private readonly DBContext _dbContext;
        public ProductServices(DBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Product AddProducts(Product product)
        {
            var entry = _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            return entry.Entity;
        }

        public void DeleteProduct(Product product)
        {
            _dbContext.Products.Remove(product);
            _dbContext.SaveChanges();
        }
        
        public List<Product> GetProducts()
        {
            return _dbContext.Products.ToList();
        }

        public Product GetProduct(Guid Id)
        {
            var prod = _dbContext.Products.AsNoTracking().Where(x => x.Id == Id).FirstOrDefault();
            return prod;
        }

        public Product UpdateProduct(Product product)
        {
            var entry = _dbContext.Products.Update(product);
            _dbContext.SaveChanges();
            return entry.Entity;
        }
    }
}
