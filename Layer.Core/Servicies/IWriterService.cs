using Layer.Core.DTOs;
using Layer.Core.DTOs.ResponseDTOs;
using Layer.Core.Entities;
using Layer.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Core.Servicies
{
    public interface IWriterService:IService<Writer>
    {
       Task<CustomResponseDto<WriterWithBooksDto>> GetSingleWriterByIdWithBooksAsync(int writerId);
    }
}
