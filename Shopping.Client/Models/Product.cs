namespace Shopping.Client.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageFile { get; set; }
        public Decimal Price { get; set; }
        public string Category { get; set; }
    }
}
