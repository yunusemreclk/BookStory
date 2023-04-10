using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Core.Entities
{
    public class Book_Category : BaseEntity
    {
        
        public int BookID { get; set; }
        public int CategoryID { get; set; }

        public Book? Book { get; set; }
        public Category? Category { get; set; }
    }
}
