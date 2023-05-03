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

        public async Task<Category> GetSingleCategoryByIdWithBooksAsync(int categoryId)
        {
            return await _context.Categories.Include(x => x.Book_Categories).Where(x => x.Id == categoryId).SingleOrDefaultAsync();
        }
    }
}
