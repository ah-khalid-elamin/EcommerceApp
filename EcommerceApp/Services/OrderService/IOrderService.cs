using EcommerceApp.Models;
namespace EcommerceApp.Services.OrderService
{
    public interface IOrderService
    {
        Order GetOrder(Guid Id);
        Order AddOrder(Order order);

        void DeleteOrder(Order order);

        Order UpdateOrder(Order order);

    }
}
