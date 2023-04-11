using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Core.Entities
{
    public class Category 
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Book_Category>? Book_Categories { get; set; }
    }
}
