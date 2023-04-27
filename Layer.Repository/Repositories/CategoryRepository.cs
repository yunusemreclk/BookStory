using Layer.Core.Entities;
using Layer.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Repository.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
       
        public CategoryRepository(BookDbContext context) : base(context)
        {
        }

        public Task<Category> GetSingleCategoryByIdWithBooksAsync(int categoryId)
        {
            return _context.Categories.Include(x => x.Book_Categories).Where(x => x.CategoryID == categoryId).SingleOrDefaultAsync();
        }
    }
}
