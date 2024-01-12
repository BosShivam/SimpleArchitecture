using SimpleArchitecture.Core.Contracts;
using SimpleArchitecture.Core.Entities;

namespace SimpleArchitecture.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public Order GetStaticOrder() => new Order
        {
            OrderId = 1,
            Name = "Cool Sunglasses",
            Notes = "Cool glasses for cool people"
        };

        public Order CreateOrder(Order order)
        {
            order.OrderId = new Random().Next(1000, 9999);
            return order;
        }
    }
}
