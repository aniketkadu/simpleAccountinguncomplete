using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Model.DTOS
{
  public  class AccountingProductDtos
    {
        public int ProductId { get; set; }
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public int ProductQty { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductDiscount { get; set; }
        public virtual AccountingPurchaseInvoiceDetail ProductPurchaseInvoice { get; set; }
        public virtual AccountingPurchaseOrderDetail ProductPurchaseOrder { get; set; }
        public virtual AccountingSalesInvoiceDetail ProductSalesInvoice { get; set; }
        public virtual AccountingSalesOrderDetail ProductSalesOrder { get; set; }
    }
}
