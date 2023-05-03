using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Layer.Core.Entities
{
    public class Book :BaseEntity
    {
        public string BookName { get; set; }
        public int WriterID { get; set; }
        public decimal Price { get; set; }
        public string Summary { get; set; }
        public string Image { get; set; }
        public short Pages { get; set; }
        public Writer? Writer { get; set; }
        public ICollection<Book_Category> Book_Categories { get; set; }
        public ICollection<InvoiceDetail> InvoiceDetails { get; set; }
        public ICollection<Cart>? Carts { get; set; }
        public ICollection<Comment>? Comments { get; set; }
    }
}
