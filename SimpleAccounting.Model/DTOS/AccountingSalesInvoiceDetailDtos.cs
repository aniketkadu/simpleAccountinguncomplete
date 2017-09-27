using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Model.DTOS
{
 public   class AccountingSalesInvoiceDetailDtos
    {

        public int SalesInvoiceDetailId { get; set; }
        public int SalesInvoiceId { get; set; }
        public virtual AccountingSalesInvoice SalesInvoiceFK { get; set; }
        public int ProductId { get; set; }
        public virtual ICollection<AccountingProductDtos> SIProductFK
        {
            get; set;
        }
    }
}
