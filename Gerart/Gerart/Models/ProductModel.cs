using System.Transactions;

namespace Gerart.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price {  get; set; } 
        public bool UseQuantity { get; set; }
        public int Quantity { get; set; }
    }
}
