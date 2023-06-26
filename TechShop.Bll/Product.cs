using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldTech.DI;

namespace WorldTech.Bll
{
    public class Product : IProduct
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }
        public double Rating { get; set; }
        public int Amount { get; set; }
    }
}
