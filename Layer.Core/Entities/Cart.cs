using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Core.Entities
{
    public class Cart : BaseEntity
    {
       
        public int BookID { get; set; }
        public byte Number { get; set; } // Maximum 10
        public Book? Book { get; set; }
    }
}
