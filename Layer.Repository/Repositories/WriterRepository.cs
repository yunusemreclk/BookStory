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
    public class WriterRepository : GenericRepository<Writer>, IWriterRepository
    {
        public WriterRepository(BookDbContext context) : base(context)
        {
        }

        public async Task<Writer> GetSingleWriterByIdWithBooksAsync(int writerId)
        {
          return await _context.Writers.Include(x=>x.Books).Where(x=>x.Id== writerId).SingleOrDefaultAsync();
        }
    }
}
