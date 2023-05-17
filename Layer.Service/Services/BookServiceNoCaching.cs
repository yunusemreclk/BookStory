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
    public class BookServiceNoCaching : Service<Book>, IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        public BookServiceNoCaching(IGenericRepository<Book> repository, IUnitOfWork unitOfWork, IBookRepository bookRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }
        public async Task<CustomResponseDto<List<BookDetailDto>>> GetBookDetailAsync(int Id)
        {
            var books = await _bookRepository.GetBookDetailAsync(Id);
            var bookDetail = _mapper.Map<List<BookDetailDto>>(books);
            return CustomResponseDto<List<BookDetailDto>>.Success(bookDetail, 200);
        }


    }
}
