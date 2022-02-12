using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReRideWebsite.Models;
using ReRideWebsite.Sevices.Interfaces;

namespace ReRideWebsite.Controllers
{
    public class CarController : Controller
    {
        // GET: CarController
        // inject service
         ICarService carService;
        public CarController(ICarService carService)
        {
            this.carService = carService;

        }
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
  
        public ActionResult AddCar(Car newCar)
        {
            // write code for insert data to db
            try
            {
                newCar.Id = Guid.NewGuid().ToString();
                carService.Add(newCar);
            }
            catch (Exception ex)
            {
                // logging
              
            }

            return View();
        }

    }
}
