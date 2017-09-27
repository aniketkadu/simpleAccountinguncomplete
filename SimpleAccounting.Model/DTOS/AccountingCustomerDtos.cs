using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Model.DTOS
{
   public class AccountingCustomerDtos
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public bool CustomerInActive { get; set; }
        public int CustomerCompanyRegno { get; set; }
        public decimal CustomerBalanceAmt { get; set; }
        public string CustomerType { get; set; }
        public string Salesman { get; set; }
        public string CustomerTelephone { get; set; }
        public string CustomerFax { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerContactPerson { get; set; }
        public string CustomerRemarks { get; set; }
        public string CustomerBilltoLine1 { get; set; }
        public string CustomerBilltoLine2 { get; set; }
        public string CustomerBilltoCity { get; set; }
        public string CustomerBilltoState { get; set; }
        public string CustomerBilltoCountry { get; set; }
        public string CustomerBilltoPostalCode { get; set; }
        public string CustomerShiptoLine1 { get; set; }
        public string CustomerShiptoLine2 { get; set; }
        public string CustomerShiptoCity { get; set; }
        public string CustomerShiptoState { get; set; }
        public string CustomerShiptoCountry { get; set; }
        public string CustomerShiptoPostalCode { get; set; }
        //Navigation Property
        public virtual ICollection<AccountingSalesOrderDtos> CustomerSalesOrder { get; set; }
        public virtual ICollection<AccountingSalesInvoiceDtos> CustomerSalesInvoice { get; set; }
    }
}
