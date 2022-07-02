using EcommerceApp.Models;

namespace EcommerceApp.Services.ProductsServices
{
    public interface IProductServices
    {
        List<Product> GetProducts();

        Product GetProduct(Guid Id);

        Product AddProducts(Product product);

        void DeleteProduct(Product product);

        Product UpdateProduct(Product product);
    }
}
