
using ReRideWebsite.Models;

namespace ReRideWebsite.Sevices.Interfaces
{
    public interface ICarService
    {
        public Car Add(Car newCar);
        public List<Car> GetAll();
        public Car Get(string id);
        public Car Update(string id,Car car);
        public Car Delete(string id);



    }
}
