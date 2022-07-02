using EcommerceApp.Models;

namespace EcommerceApp.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly DBContext _dbContext;
        public OrderService(DBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Order AddOrder(Order order)
        {
            var entry = _dbContext.Order.Add(order);
            _dbContext.SaveChanges();
            return entry.Entity;
        }

        public void DeleteOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public Order GetOrder(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Order UpdateOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
