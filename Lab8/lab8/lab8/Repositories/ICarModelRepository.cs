using lab8.Models;
using lab8.Models.ViewModels;

namespace lab8.Repositories
{
    public interface ICarModelRepository
    {
        List<CarModelVm> GetAll();
        CarModel? GetById(int id);
        void Add(CarModel carModel);
        void Update(CarModel carModel);
        void Delete(int id);
    }
}
