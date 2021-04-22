using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Entities
{
    public class Product : Category
    { 
        public static int ID = 1;
        public string ProductManufacturer { get; set; }

        [StringLength(4)]

        public List<Category> ProductCategory { get; set; }
        public int SellingPrice { get; set; }
       
        public int Product_ID { get; set; }

        public static int GenerateProductId()
        {
            return ID++;
        }

        public Product()
        {
            this.ProductCategory = new List<Category>();
        }
    }
}
