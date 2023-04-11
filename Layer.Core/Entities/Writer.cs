using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Core.Entities
{
    public class Writer 
    {
        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public string Biography { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
