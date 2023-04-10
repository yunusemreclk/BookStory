using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Core.Entities
{
    public class InvoiceDetail  : BaseEntity
    {
        public int InvoiceID { get; set; }
        public int BookID { get; set; }
        public byte Number { get; set; }
        public decimal Price { get; set; }
        public Invoice? Invoice { get; set; }
        public Book? Book { get; set; }
    }
}
