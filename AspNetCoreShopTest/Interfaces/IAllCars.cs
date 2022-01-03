using AspNetCoreShopTest.Models;

namespace AspNetCoreShopTest.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get;/* set;*/ }
        IEnumerable<Car> GetFavCars { get; set; }
        Car getObjectCar (Guid carId);
    }
}
