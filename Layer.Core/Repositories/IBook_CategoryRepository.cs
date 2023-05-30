using Layer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Core.Repositories
{
   public interface IBook_CategoryRepository:IGenericRepository<Book_Category>
    {
        Task<List<Book_Category>> GetBook_CategoryDetail(int Id);
    }
}
