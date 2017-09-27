using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Model.DTOS
{
 public   class AccountingPurchaseInvoiceDetailDtos
    {
        public int PurchaseInvoiceDetailId { get; set; }
        //Foreign keys
        public int PurchaseInvoiceId { get; set; }
        public virtual AccountingPurchaseInvoice PurchaseInvoiceFK { get; set; }
        public int ProductId { get; set; }
        public virtual ICollection<AccountingProduct> PIProductFK { get; set; }

    }
}
