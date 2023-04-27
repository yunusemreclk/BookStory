using Layer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Core.DTOs
{
    public class BookDetailDto:BookDto
    {
        public WriterDto Writer { get; set; }
        public List<CommentDto> Comments { get; set; }
        public List<Book_CategoryDto> Book_Categories { get; set; }
    
    }
}
