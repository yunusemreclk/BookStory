using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Core.Entities
{
    public class Invoice 
    {
        public int InvoiceID { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CreateDate { get; set; }
        public ICollection<InvoiceDetail>? InvoiceDetails { get; set; }
    }
}
