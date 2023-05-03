using Layer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Core.Repositories
{
    public interface IBookRepository:IGenericRepository<Book>
    {
       Task<List<Book>> GetBookDetailAsync(int Id);
    }
}
