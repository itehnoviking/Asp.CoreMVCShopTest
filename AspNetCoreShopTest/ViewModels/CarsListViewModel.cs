using AspNetCoreShopTest.Models;

namespace AspNetCoreShopTest.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> AllCars { get; set; }
        public string CurrCategory { get; set; }
    }
}
