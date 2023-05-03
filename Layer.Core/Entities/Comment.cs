using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Core.Entities
{
    public class Comment: BaseEntity
    {
        public int BookID { get; set; }
        public string CommentText { get; set; }
        public DateTime CreatedDate { get; set; }
        public Book? Book { get; set; }  
    }
}
