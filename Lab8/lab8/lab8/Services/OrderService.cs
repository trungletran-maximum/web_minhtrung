using lab8.Models;
using lab8.Repositories;

namespace lab8.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;

        public OrderService(IOrderRepository repository)
        {
            _repository = repository;
        }

        public List<Order> GetAllOrders()
        {
            return _repository.GetAll();
        }

        public Order? GetOrderById(int id)
        {
            return _repository.GetById(id);
        }

        public void CreateOrder(Order order)
        {
            _repository.Add(order);
        }

        public void DeleteOrder(int id)
        {
            _repository.Delete(id);
        }
    }
}
