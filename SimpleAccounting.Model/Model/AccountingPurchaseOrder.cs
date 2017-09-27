using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Model
{
   public class AccountingPurchaseOrder : AuditableEntity<long>
    {
        public int PurchaseOrderId { get; set; }
        public int PurchaseOrderNo { get; set; }
        public DateTime PurchaseOrderDate { get; set; }
        public DateTime PurchaseOrderDeliveryDate { get; set; }
        public string PurchaseSupplierName { get; set; }
        public string PurchaseOrderBillToLine1 { get; set; }
        public string PurchaseOrderShipToLine1 { get; set; }
        public decimal PurchaseProductAmt { get; set; }
        public string PurchaseTandC { get; set; }
        //foreign key
        public int SupplierId { get; set; }
        public virtual AccountingSupplier POSupplier { get; set; }
        //public virtual ICollection<AccountingPurchaseOrderDetail> PurchaseOrderDetail { get; set; }
        public virtual AccountingPurchaseOrderDetail PurchaseOrderDetail { get; set; }
    }
}
