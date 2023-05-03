using AutoMapper;
using Layer.Core.DTOs;
using Layer.Core.DTOs.ResponseDTOs;
using Layer.Core.Entities;
using Layer.Core.Servicies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Layer.API.Controllers
{
    public class CategoriesController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly ICategoryService _service;
        public CategoriesController(IMapper mapper, ICategoryService categoryService)
        {
            _service = categoryService;
            _mapper = mapper;
        }
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetSingleCategoryByIdWithBooksAsync(int id)
        {
            return CreateActionResult(await _service.GetSingleCategoryByIdWithBooksAsync(id));
        }
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var category= await _service.GetAllAsync();
            var categoryDtos=_mapper.Map<List<CategoryDto>>(category);
            return CreateActionResult(CustomResponseDto<List<CategoryDto>>.Success(categoryDtos,200));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category=await _service.GetByIdAsync(id);
            var categoryDto= _mapper.Map<CategoryDto>(category);
            return CreateActionResult(CustomResponseDto<CategoryDto>.Success(categoryDto,200));
        }
        [HttpPost]
        public async Task<IActionResult> Save(CategoryDto categoryDto)
        { 
          var category =await _service.AddAsync(_mapper.Map<Category>(categoryDto));
          var categorysDto= _mapper.Map<CategoryDto>(category);
          return CreateActionResult(CustomResponseDto<CategoryDto>.Success(categorysDto ,201));
        }
        [HttpPut]
        public async Task <IActionResult> Update(CategoryDto categoryDto)
        {
            await _service.UpdateAsync(_mapper.Map<Category>(categoryDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var category= await _service.GetByIdAsync(id);
            await _service.RemoveAsync(category);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
