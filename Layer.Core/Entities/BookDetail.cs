using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Core.Entities
{
    internal class BookDetail
    {
        public int BookDetailID { get; set; }
        public Book Book { get; set; }
        public ICollection<Book_Category> Categories { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
