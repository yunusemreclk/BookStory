using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Core.DTOs
{
    public class InvoiceDto
    {
        public int InvoiceID { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
