using Layer.Core.DTOs.ResponseDTOs;
using Layer.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layer.Core.Services;
using Layer.Core.Entities;

namespace Layer.Core.Servicies
{
   public interface IBook_CategoryServices:IService<Book_Category>
    {
        Task<CustomResponseDto<List<Book_CategoryDto>>> GetBook_CategoryDetailAsync(int Id);
    }
}
