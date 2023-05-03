using AutoMapper;
using Layer.Core.DTOs;
using Layer.Core.DTOs.ResponseDTOs;
using Layer.Core.Entities;
using Layer.Core.IUnitOfWork;
using Layer.Core.Repositories;
using Layer.Core.Servicies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Service.Services
{
    public class WriterService : Service<Writer>,IWriterService
    {
        private readonly IWriterRepository _writerRepository;
        private readonly IMapper _mapper;
        public WriterService(IGenericRepository<Writer> repository, IUnitOfWork unitOfWork,IWriterRepository writerRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _writerRepository = writerRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<WriterWithBooksDto>> GetSingleWriterByIdWithBooksAsync(int writerId)
        {
            var writer = await _writerRepository.GetSingleWriterByIdWithBooksAsync(writerId);
            var writerDto= _mapper.Map<WriterWithBooksDto>(writer);
            return CustomResponseDto<WriterWithBooksDto>.Success(writerDto, 200);
        }

    }
}
