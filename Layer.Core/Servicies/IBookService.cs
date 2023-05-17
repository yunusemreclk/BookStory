using Layer.Core.DTOs;
using Layer.Core.DTOs.ResponseDTOs;
using Layer.Core.Entities;
using Layer.Core.Repositories;
using Layer.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Core.Servicies
{
    public interface IBookService:IService<Book>
    {
        Task<CustomResponseDto<List<BookDetailDto>>> GetBookDetailAsync(int Id);
     
    }
}
