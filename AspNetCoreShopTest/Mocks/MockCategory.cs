using AspNetCoreShopTest.Interfaces;
using AspNetCoreShopTest.Models;

namespace AspNetCoreShopTest.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Электромобили", Desc = "Автомобили с электродвигателем"},
                    new Category { CategoryName = "Классические автомобили", Desc = "Автомобили с двигателем внутреннего сгорания"}
                };

            }       
        }
    }
}
