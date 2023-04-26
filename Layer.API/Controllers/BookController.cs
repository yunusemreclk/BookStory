using AutoMapper;
using Layer.Core.DTOs;
using Layer.Core.DTOs.ResponseDTOs;
using Layer.Core.Entities;
using Layer.Core.Services;
using Layer.Core.Servicies;
using Microsoft.AspNetCore.Mvc;

namespace Layer.API.Controllers
{
    public class BookController :CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<Book> _service;
        private readonly IBookService _bookService;
        public BookController(IMapper mapper, IService<Book> service, IBookService bookService)
        {
            _mapper = mapper;
            _service = service;
            _bookService = bookService;
        }
        [HttpGet("[action]/{id}")]
        public async Task <IActionResult> GetBookDetail(int id)
        {
            return CreateActionResult(await _bookService.GetBookDetailAsync(id));
        }
      

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var books = await _service.GetAllAsync();
            var bookDtos=  _mapper.Map<List<BookDto>>(books.ToList());
            return CreateActionResult(CustomResponseDto<List<BookDto>>.Success(bookDtos,200));
        }
        [HttpGet("{id}")]
        public async Task <IActionResult> GetById(int id)
        {
            var book= await _service.GetByIdAsync(id);
            var bookDto= _mapper.Map<BookDto>(book);
            return CreateActionResult(CustomResponseDto<BookDto>.Success(bookDto,204));
        }
        [HttpPost]
        public async Task<IActionResult> Save(BookDto bookDto)
        {
            var book =await _service.AddAsync(_mapper.Map<Book>(bookDto));
            var booksDto= _mapper.Map<BookDto>(book);
            return CreateActionResult(CustomResponseDto<BookDto>.Success(booksDto,201));
        }
        [HttpPut]
        public async Task<IActionResult> Update(BookDto bookDto)
        {
            var book = _service.UpdateAsync(_mapper.Map<Book>(bookDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
        [HttpDelete("{id}")]
        public async Task <IActionResult>Remove (int id)
        {
            var book = await _service.GetByIdAsync(id);
             await _service.RemoveAsync(book);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(200));
        }
    }
}
