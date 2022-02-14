using Microsoft.AspNetCore.Mvc;
using ReRideWebsite.Sevices.Interfaces;

namespace ReRideWebsite.Controllers
{
    public class AdminController : Controller
    {
       
        ICarService carService;
        public AdminController(ICarService carService)
        {
            this.carService = carService;
                
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult viewCars()
        {
            var result=carService.GetAll();
            return View(result);
        }
    }
}
