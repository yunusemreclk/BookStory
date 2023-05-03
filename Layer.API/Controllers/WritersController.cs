using AutoMapper;
using Layer.Core.DTOs;
using Layer.Core.DTOs.ResponseDTOs;
using Layer.Core.Entities;
using Layer.Core.Servicies;
using Microsoft.AspNetCore.Mvc;

namespace Layer.API.Controllers
{
    public class WritersController : CustomBaseController
    {
        private readonly IWriterService _service;
        private readonly IMapper _mapper;
        public WritersController( IWriterService writerService, IMapper mapper)
        {
            _mapper= mapper;
            _service = writerService;
        }
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetSingleWriterByIdWithBooksAsync(int id)
        {
            return CreateActionResult(await _service.GetSingleWriterByIdWithBooksAsync(id));
        }
        [HttpGet]
        public async Task<IActionResult> All()
        {
        var writers=await _service.GetAllAsync();
        var writersDto= _mapper.Map<List<WriterDto>>(writers);
        return CreateActionResult(CustomResponseDto<List<WriterDto>>.Success(writersDto,200));
        }
        [HttpGet("{id}")]
        public async Task <IActionResult> GetById(int id)
        {
            var writer=await _service.GetByIdAsync(id);
            var writerDto= _mapper.Map<WriterDto>(writer);
            return CreateActionResult(CustomResponseDto<WriterDto>.Success(writerDto,200));
        }
        [HttpPost]
        public async Task <IActionResult> Save(WriterDto writerDto)
        {
            var writer=_service.AddAsync(_mapper.Map<Writer>(writerDto));
            var writersDto = _mapper.Map<List<WriterDto>>(writer);
            return CreateActionResult(CustomResponseDto<List<WriterDto>>.Success(writersDto, 201));
        }
        [HttpPut]
        public async Task<IActionResult> Update(WriterDto writerDto)
        {
            var writer= _service.UpdateAsync(_mapper.Map<Writer>(writerDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
        [HttpDelete]
        public async Task<IActionResult> Remove(int id)
        {
            var writer = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(writer);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));

        }
    }
}
