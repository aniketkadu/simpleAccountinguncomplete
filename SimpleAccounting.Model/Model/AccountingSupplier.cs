using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Model
{
  public  class AccountingSupplier : AuditableEntity<long>
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public bool SupplierInActive { get; set; }
        public int SupplierCompanyRegno { get; set; }
        public decimal SupplierBalanceAmt { get; set; }
        public string SupplierTelephone { get; set; }
        public string SupplierFax { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierContactPerson { get; set; }
        public string SupplierRemarks { get; set; }
        public string SupplierBilltoLine1 { get; set; }
        public string SupplierBilltoLine2 { get; set; }
        public string SupplierBilltoCity { get; set; }
        public string SupplierBilltoState { get; set; }
        public string SupplierBilltoCountry { get; set; }
        public string SupplierBilltoPostalCode { get; set; }
        public string SupplierShiptoLine1 { get; set; }
        public string SupplierShiptoLine2 { get; set; }
        public string SupplierShiptoCity { get; set; }
        public string SupplierShiptoState { get; set; }
        public string SupplierShiptoCountry { get; set; }
        public string SupplierShiptoPostalCode { get; set; }
        //Navigation Property
        public virtual ICollection<AccountingPurchaseOrder> SupplierPurchaseOrder { get; set; }
        public virtual ICollection<AccountingPurchaseInvoice> SupplierPurchaseInvoice { get; set; }
    }
}
