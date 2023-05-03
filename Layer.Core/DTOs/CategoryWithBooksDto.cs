using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Core.DTOs
{
    public class CategoryWithBooksDto
    {  
        public string  CategoryName { get; set; }
        public List<Book_CategoryDto> Book_Categories { get; set; }
      

    }
}
