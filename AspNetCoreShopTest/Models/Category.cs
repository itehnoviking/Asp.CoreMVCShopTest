namespace AspNetCoreShopTest.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public string CategoryName { get; set; }
        public string Desc { get; set; }
        public IEnumerable<Car> Cars { get; set; }
    }
}
