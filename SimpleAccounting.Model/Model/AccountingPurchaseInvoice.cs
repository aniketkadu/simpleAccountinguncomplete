using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Model
{
   public class AccountingPurchaseInvoice :AuditableEntity<long>
    {

        public int PurchaseInvoiceId { get; set; }
        public int PurchaseInvoiceNo { get; set; }
        public DateTime PurchaseInvoiceDate { get; set; }
        public int PurchaseInvoicePOno { get; set; }
        public string PurchaseSupplierName { get; set; }
        public string PurchaseInvoiceBillToLine1 { get; set; }
        public string PurchaseInvoiceShipToLine1 { get; set; }
        public decimal PurchaseProductAmt { get; set; }
        public string PurchaseTandC { get; set; }
        //foreign key
        public int SupplierId { get; set; }
        public virtual AccountingSupplier PISupplier { get; set; }
        //public virtual ICollection<AccountingPurchaseInvoiceDetail> PurchaseInvoiceDetail { get; private set; }
        public virtual AccountingPurchaseInvoiceDetail PurchaseInvoiceDetail { get; set; }
    }
}
