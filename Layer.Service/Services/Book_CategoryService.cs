using AutoMapper;
using Layer.Core.DTOs;
using Layer.Core.DTOs.ResponseDTOs;
using Layer.Core.Entities;
using Layer.Core.IUnitOfWork;
using Layer.Core.Repositories;
using Layer.Core.Servicies;
using Layer.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Service.Services
{
    public class Book_CategoryService : Service<Book_Category>, IBook_CategoryServices
    {
        private readonly IBook_CategoryRepository _book_CategoryRepository;
        private readonly IMapper _mapper;
        public Book_CategoryService(IGenericRepository<Book_Category> repository, IUnitOfWork unitOfWork, IBook_CategoryRepository book_CategoryRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _book_CategoryRepository = book_CategoryRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<List<Book_CategoryDto>>> GetBook_CategoryDetailAsync(int Id)
        {
            var book_Categories = await _book_CategoryRepository.GetBook_CategoryDetail(Id);
            var bookCategoryDetail = _mapper.Map<List<Book_CategoryDto>>(book_Categories);
            return CustomResponseDto<List<Book_CategoryDto>>.Success(bookCategoryDetail,200);
        }
    }
}
