using Gerart.Enums;

namespace Gerart.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }

        public Store store { get; set; }

    }
}
