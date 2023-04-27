using AutoMapper;
using Layer.Core.DTOs;
using Layer.Core.Servicies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Layer.API.Controllers
{
    public class CategoriesController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;
        public CategoriesController(IMapper mapper, ICategoryService categoryService)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        [HttpGet("[action]/{Id}")]
        public async Task<IActionResult> GetSingleCategoryByIdWithBooksAsync(int Id)
        {
            return CreateActionResult(await _categoryService.GetSingleCategoryByIdWithBooksAsync(Id));
        }



    }
}
