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
    public class CategoryService : Service<Category>, ICategoryService
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(IGenericRepository<Category> repository, IUnitOfWork unitOfWork,ICategoryRepository categoryRepository,IMapper mapper) : base(repository, unitOfWork)
        {
            _categoryRepository= categoryRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<CategoryWithBooksDto>> GetSingleCategoryByIdWithBooksAsync(int categoryId)
        {
            var category = await _categoryRepository.GetSingleCategoryByIdWithBooksAsync(categoryId);
            var categoryDto= _mapper.Map<CategoryWithBooksDto>(category);
            return CustomResponseDto<CategoryWithBooksDto>.Success(categoryDto, 200);

        }
    }
}
