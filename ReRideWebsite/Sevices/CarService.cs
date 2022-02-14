
using ReRideWebsite.Models;
using ReRideWebsite.Sevices.Interfaces;

namespace ReRideWebsite.Sevices
{
    public class CarService : ICarService
    {
        ReRideDbContext _dbContext;
        public CarService(ReRideDbContext _dbContext)
        {
            this._dbContext = _dbContext;
        }
        public Car Add(Car newCar)
        {

            //db code
            try
            {
                _dbContext.Add(newCar);
                _dbContext.SaveChanges();

            }
            catch (Exception exp)
            {

               
            }

            return newCar;

        }

        public Car Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Car Get(string id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            throw new NotImplementedException();
        }

        public Car Update(string id, Car car)
        {
            throw new NotImplementedException();
        }
    }
}
