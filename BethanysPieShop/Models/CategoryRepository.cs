using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class CategoryRepository:ICategoryRepository
    {
        //bring AppDbContext using constructor injection
        private readonly AppDbContext _appDbContext;
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> AllCategories => _appDbContext.Categories;
    }
}
