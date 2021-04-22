using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Entities
{
    public class ProductStore
    {
        public static List<Product> products = new List<Product>()
        {
            new Product()
            {
                Product_ID = Product.GenerateProductId(),
                Name = "Spikes",
                ShortCode = "SPIK",
                Description = "GOOD QUALITY",
                SellingPrice = 12000,
                ProductCategory = new List<Category>() {CategoryOperation.categories[1]},
                ProductManufacturer = "PUMA"
            },

            new Product()
            {
                Product_ID = Product.GenerateProductId(),
                Name = "Sneakers",
                ShortCode = "SNKR",
                Description = "Sneakers are stylish shoes",
                SellingPrice = 2550,
                ProductCategory = new List<Category>() {CategoryOperation.categories[0]},
                ProductManufacturer = "NIKE"
            },
        };
    }
}
