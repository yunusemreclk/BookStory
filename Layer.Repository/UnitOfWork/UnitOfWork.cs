using Layer.Core.IUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Repository.UnitOfWork
{
    public class UnitOfWork: IUnitOfWork
    {
        protected readonly BookDbContext _context;
        public UnitOfWork(BookDbContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }
        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}