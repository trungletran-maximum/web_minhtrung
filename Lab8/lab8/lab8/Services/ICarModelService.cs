using lab8.Models;
using lab8.Models.ViewModels;

namespace lab8.Services
{
    public interface ICarModelService
    {
        List<CarModelVm> GetCarModels();
        CarModel? GetCarModelById(int id);
        void CreateCarModel(CarModel carModel);
        void UpdateCarModel(CarModel carModel);
        void DeleteCarModel(int id);
    }
}
