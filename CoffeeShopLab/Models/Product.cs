using Dapper.Contrib.Extensions;

namespace CoffeeShopLab.Models
{
    [Table("product")]
    public class Product
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public int inventory { get; set; }

        public override string ToString()
        {
            return $"{id} {name} {description} {price} {inventory}";
        }
    }
}
