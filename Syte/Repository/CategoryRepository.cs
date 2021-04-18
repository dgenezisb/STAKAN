using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Interfaces;
using Syte.Models;

namespace Syte.Repository
{
    public class CategoryRepository : ICategories
    {
        private readonly AppDBContext appDBContent;
        public CategoryRepository(AppDBContext appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Category> ListofCategories => appDBContent.Category;
    }
}
