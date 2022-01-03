using AspNetCoreShopTest.Models;

namespace AspNetCoreShopTest.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
