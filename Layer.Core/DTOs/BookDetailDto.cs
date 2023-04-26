using Layer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Core.DTOs
{
    public class BookDetailDto
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public int WriterID { get; set; }
        public decimal Price { get; set; }
        public string Summary { get; set; }
        public string Image { get; set; }
        public short Pages { get; set; }
        public int CategoryID { get; set; }
        public int CommentID { get; set; }
        public int Book_CategoryID { get; set; }

        public WriterDto Writer { get; set; }
        public CommentDto Comment { get; set; }
        public Book_CategoryDto Book_Category { get; set; }

     
    }
}
