using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApplication.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryId=1, CategoryName="Fruit pies", Description = "All fruits" },
                    new Category{CategoryId=2, CategoryName="Chesse pies", Description = "3 cheese pie" },
                    new Category{CategoryId=3, CategoryName="Seasonal pies", Description = "general pie" }

                };
            }
        }
    }
}
