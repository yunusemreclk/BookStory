using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Core.DTOs
{
   public class WriterWithBooksDto 
    {
        public string WriterName { get; set; }
        public string Biography { get; set; }
        public List<BookDto> Books { get; set; }
  
    }
}
