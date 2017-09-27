using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Model.DTOS
{
  public  class AccountingSalesInvoiceDtos
    {
        public int SalesInvoiceId { get; set; }
        public int SalesInvoiceNo { get; set; }
        public DateTime SalesInvoiceDate { get; set; }
        public int SalesInvoicePOno { get; set; }
        public string SalesCustomerName { get; set; }
        public string SalesInvoiceBillToLine1 { get; set; }
        public string SalesInvoiceShipToLine1 { get; set; }
        public decimal SalesProductAmt { get; set; }
        public string SalesTandC { get; set; }
        //foreign key
        public int CustomerId { get; set; }
        public virtual AccountingCustomerDtos SICustomer { get; set; }
        //public virtual ICollection<AccountingSalesInvoiceDetail> SalesInvoiceDetail { get; private set; }
        public virtual AccountingSalesInvoiceDetailDtos SalesInvoiceDetail { get; set; }
    }
}
