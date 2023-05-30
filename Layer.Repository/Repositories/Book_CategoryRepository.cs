using Layer.Core.Entities;
using Layer.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Repository.Repositories
{
    public class Book_CategoryRepository : GenericRepository<Book_Category>, IBook_CategoryRepository
    {
        public Book_CategoryRepository(BookDbContext context) : base(context)
        {
        }

        public async Task<List<Book_Category>> GetBook_CategoryDetail(int Id)
        {
          return  await _context.Book_Categories.Include(x => x.Book).Where(x => x.Id == Id).Include(x => x.Category).Where(x => x.Id == Id).ToListAsync();
        }
    }
}
