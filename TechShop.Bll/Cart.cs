using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldTech.DI;

namespace WorldTech.Bll
{
    public class Cart : ICart
    {
        public List<(IProduct, int)> Products { get; set; }
        public int Price { get; set; }

        public void BuyProducts(ICart cart)
        {
            foreach (var product in cart.Products)
            {
                Products.Add(product);
                Price += product.Item1.Price * product.Item2;
            }
        }

        public void RemoveAllProductsFromCart()
        {
            Products.Clear();
        }

        public void RemoveProductFromCart((IProduct, int) product)
        {
            if(product.Item2 > 0)
            {
                product.Item2 -= 1;
            }
            else
            {
                Products.Remove(product);
            }
        }
    }
}
