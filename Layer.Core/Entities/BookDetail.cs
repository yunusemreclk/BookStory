using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Layer.Core.Entities
{
    public class BookDetail : BaseEntity
    {
        public Book Book { get; set; }
        public ICollection<Book_Category> Categories { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}
