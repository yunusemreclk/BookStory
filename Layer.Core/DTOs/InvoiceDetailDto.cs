using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Core.DTOs
{
    public class InvoiceDetailDto
    {
        public int InvoiceDetailID { get; set; }
        public int InvoiceID { get; set; }
        public int BookID { get; set; }
        public byte Number { get; set; }
        public decimal Price { get; set; }
    }
}
