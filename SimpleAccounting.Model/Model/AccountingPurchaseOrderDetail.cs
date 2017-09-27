using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Model
{
   public class AccountingPurchaseOrderDetail : AuditableEntity<long>
    {
        public int PurchaseOrderDetailId { get; set; }
        public int PurchaseOrderId { get; set; }
        public virtual AccountingPurchaseOrder PurchaseOrderFK { get; set; }
        public int ProductId { get; set; }
        public virtual ICollection<AccountingProduct> POProductFK { get; set; }
    }
}
