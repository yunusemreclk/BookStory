using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Core.DTOs
{
    public class CommentDto
    {
        public int CommentID { get; set; }
        public int BookID { get; set; }
        public string CommentText { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
