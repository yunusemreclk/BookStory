using Layer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Core.Repositories
{
    public interface ICategoryRepository:IGenericRepository<Category>
    {
      Task<Category> GetSingleCategoryByIdWithBooksAsync(int categoryId);
    }
}
