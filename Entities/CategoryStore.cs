using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Entities
{
    public class CategoryStore
    {
        public static List<Category> categories = new List<Category>()
        {
            new Category()
            {
              ID = Category.GenerateCategoryId(),
              Name="Gymming",
              ShortCode="GYMM",
              Description="Gym is goods for fitness"
            },
            new Category
            {
                ID = Category.GenerateCategoryId(),
                Name="Riding",
                ShortCode="RIDN",
                Description="Riding Bikes"
            },
            new Category
            {
                ID = Category.GenerateCategoryId(),
                Name="Dancing",
                ShortCode="DANC",
                Description="Good Moves"
            }
        };
    }
}
