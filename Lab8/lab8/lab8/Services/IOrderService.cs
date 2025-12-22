using lab8.Models;

namespace lab8.Services
{
    public interface IOrderService
    {
        List<Order> GetAllOrders();
        Order? GetOrderById(int id);
        void CreateOrder(Order order);
        void DeleteOrder(int id);
    }
}
