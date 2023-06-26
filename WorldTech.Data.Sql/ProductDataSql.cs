using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldTech.DI;

namespace WorldTech.Data.Sql
{
    public class ProductDataSql : IProductsData<IProduct>
    {
        public IEnumerable<IProduct> FindProducts(string input)
        {
            using (var database = new WorldTechContext())
            {
                List<IProduct> foundProducts = new List<IProduct>();
                foreach (var product in database.Products)
                {
                    if (product.Type.ToLower().Contains(input.ToLower()) || product.Manufacturer.ToLower().Contains(input.ToLower())
                        || product.Model.ToLower().Contains(input.ToLower()))
                    {
                        foundProducts.Add(product);
                    }
                }
                return foundProducts;
            }
        }

        public IEnumerable<IProduct> UpdateProductList()
        {
            using (var database = new WorldTechContext())
            {
                return database.Products.ToList();
            }
        }
    }
}
