using AspNetCoreShopTest.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreShopTest.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCarsCategory;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCarsCategory = iCarsCat;
        }

        public IActionResult List()

        {
            var cars = _allCars.Cars;
            return View(cars);
        }
    }
}
