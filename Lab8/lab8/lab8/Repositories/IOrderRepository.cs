using lab8.Models;

namespace lab8.Repositories
{
    public interface IOrderRepository
    {
        List<Order> GetAll();
        Order? GetById(int id);
        void Add(Order order);
        void Delete(int id);
    }
}
