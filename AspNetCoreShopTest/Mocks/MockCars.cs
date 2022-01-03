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
                        Img = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4f/Tesla_Model_S_02_2013.jpg/1280px-Tesla_Model_S_02_2013.jpg",
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
                        Img = "https://auto.ironhorse.ru/wp-content/uploads/2020/03/polo-2-ru-front.jpg",
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
                        Img = "https://auto.ironhorse.ru/wp-content/uploads/2015/09/Talisman-wagon.jpg",
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
