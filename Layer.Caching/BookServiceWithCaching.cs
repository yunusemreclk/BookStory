using AutoMapper;
using Layer.Core.DTOs;
using Layer.Core.DTOs.ResponseDTOs;
using Layer.Core.Entities;
using Layer.Core.IUnitOfWork;
using Layer.Core.Repositories;
using Layer.Core.Servicies;
using Layer.Service.Exceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Caching
{
    public class BookServiceWithCaching : IBookService
    {
        private const string CacheBookKey = "booksCache";
        private readonly IMapper _mapper; 
        private readonly IMemoryCache _memoryCache;
        private readonly IBookRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public BookServiceWithCaching(IMapper mapper, IMemoryCache memoryCache, IBookRepository repository, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _memoryCache = memoryCache;
            _repository = repository;
            _unitOfWork = unitOfWork;
            if (!_memoryCache.TryGetValue(CacheBookKey, out  _))
            {
                _memoryCache.Set(CacheBookKey,_repository.GetAll().ToList());
            }
        }

        public async Task<Book> AddAsync(Book entity)
        {
           await _repository.AddAsync(entity);
           await _unitOfWork.CommitAsync();
           await CacheAllBooksAsync();
           return entity;
        }

        public async Task<IEnumerable<Book>> AddRangeAsync(IEnumerable<Book> entities)
        {
           await _repository.AddRangeAsync(entities);
            await _unitOfWork.CommitAsync();
            await CacheAllBooksAsync();
            return entities;
        }

        public async Task<bool> AnyAsync(Expression<Func<Book, bool>> expression)
        {
         var result = await _repository.AnyAsync(expression);
         return result;
          
        }

        public Task<IEnumerable<Book>> GetAllAsync()
        {
           return Task.FromResult(_memoryCache.Get<IEnumerable<Book>>(CacheBookKey));
        }

        public async Task<CustomResponseDto<List<BookDetailDto>>> GetBookDetailAsync(int Id)
        {
            var books= await _repository.GetBookDetailAsync(Id);
            var booksDetailDto=_mapper.Map<List<BookDetailDto>>(books);
            return CustomResponseDto<List<BookDetailDto>>.Success(booksDetailDto,200);
        }

        public Task<Book> GetByIdAsync(int Id)
        {
            var book = _memoryCache.Get<List<Book>>(CacheBookKey).FirstOrDefault(x => x.Id == Id);
            if (book==null)
            {
                throw new NotFoundException($"{typeof(Book).Name} ({Id})not found");
            }
            return Task.FromResult(book);
        }

        public async Task RemoveAsync(Book entity)
        {
            _repository.Remove (entity); 
            await _unitOfWork.CommitAsync();
            await CacheAllBooksAsync();
            
        }

        public async Task RemoveRangeAsync(IEnumerable<Book> entities)
        {
            _repository.RemoveRange(entities);
            await _unitOfWork.CommitAsync();
            await CacheAllBooksAsync();
        }

        public async Task UpdateAsync(Book entity)
        {
            _repository.Update (entity);
            await _unitOfWork.CommitAsync ();
            await CacheAllBooksAsync();
        }

        public IQueryable<Book> Wehere(Expression<Func<Book, bool>> expression)
        {
            return _memoryCache.Get<List<Book>>(CacheBookKey).Where(expression.Compile()).AsQueryable();
        }

        public async Task CacheAllBooksAsync()
        {
            _memoryCache.Set(CacheBookKey, await _repository.GetAll().ToListAsync());
        }
    }
}
