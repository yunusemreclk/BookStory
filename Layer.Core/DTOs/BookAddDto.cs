using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Core.DTOs
{
    public class BookAddDto
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public int WriterID { get; set; }
        public decimal Price { get; set; }
        public string Summary { get; set; }
        public string Image { get; set; }
        public short Pages { get; set; }
        public List<Book_CategoryDto> Book_Categories { get; set; }
    }
}
