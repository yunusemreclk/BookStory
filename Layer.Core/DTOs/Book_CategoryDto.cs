using Layer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Core.DTOs
{
    public class Book_CategoryDto
    {
        public int ID { get; set; }
        public int BookID { get; set; }
        public int CategoryID { get; set; }


    }
}
