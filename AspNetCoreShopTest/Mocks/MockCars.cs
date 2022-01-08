using AspNetCoreShopTest.Interfaces;
using AspNetCoreShopTest.Models;

namespace AspNetCoreShopTest.Mocks
{
    public class MockCars : IAllCars
    {

        private readonly ICarsCategory carsCategory = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {   Name = "Tesla Model S",
                        ShortDesc = "Fast car",
                        LongDesc = "Beautiful, fast and very quiet Tesla car",
                        Img = "/img/Tesla Model S.jpg",
                        Price = 45000,
                        Available = true,
                        IsFavourite = true,
                        Category = carsCategory.AllCategories.First()
                    },
                    new Car
                    {
                        Name = "VolksWagen Polo",
                        ShortDesc = "Quiet and calm",
                        LongDesc = "Comfortable car for city life",
                        Img = "/img/VW Polo.jpg",
                        Price = 28000,
                        Available = true,
                        IsFavourite = true,
                        Category = carsCategory.AllCategories.Last()
                    },
                    new Car
                    {
                        Name = "Reno Talisman",
                        ShortDesc = "Modern and stylish",
                        LongDesc = "Comfortable car for city life",
                        Img = "/img/Reno Talisman.jpg",
                        Price = 32000,
                        Available = true,
                        IsFavourite = true,
                        Category = carsCategory.AllCategories.Last()
                    }
                };

            }
        }

        public IEnumerable<Car> GetFavCars { get ; set; }

        public Car getObjectCar(Guid carId)
        {
            throw new NotImplementedException();
        }
    }
}
