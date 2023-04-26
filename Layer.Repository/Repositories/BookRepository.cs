using Layer.Core.DTOs;
using Layer.Core.DTOs.ViewModel;
using Layer.Core.Entities;
using Layer.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Repository.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {

        public BookRepository(BookDbContext context) : base(context)
        {
        }
        public async Task<List<Book>> GetBookDetailAsync(int Id)
        {

            return await _context.Books.Include(x => x.Writer).Where(x => x.BookID == Id).Include(x => x.Comments).Where(x => x.BookID == Id).Include(x => x.Book_Categories).Where(x => x.BookID == Id).ToListAsync();

            //await _context.Books.Include("Writer").Where(x => x.BookID == Id).ToListAsync();
            //return await _context.Books.Include(x=>x.Comments).Where(x => x.BookID == Id).ToListAsync();
        }
    }
   }
