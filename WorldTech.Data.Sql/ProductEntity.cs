using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldTech.DI;

namespace WorldTech.Data.Sql
{
    public class ProductEntity : IProduct
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }
        public double Rating { get; set; }
        public int Amount { get; set; }

        public ProductEntity() { }

        public ProductEntity(IProduct item)
        {
            Id = 0;
            Type = item.Type;
            Model = item.Model;
            Manufacturer = item.Manufacturer;
            Price = item.Price;
            Rating = item.Rating;
            Amount = item.Amount;
        }
    }
}
