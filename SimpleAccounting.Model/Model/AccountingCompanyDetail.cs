using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Model
{
  public  class AccountingCompanyDetail : Entity<int>
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int CompanyRegno { get; set; }
        public string CompanyTelephone { get; set; }
        public string CompanyEmail { get; set; }
        public DateTime FinancialYrStartDate { get; set; }
        public byte[] CompanyLogo { get; set; }
        public string SoftwareSerialNo { get; set; }
        public string BilltoLine1 { get; set; }
        public string BilltoLine2 { get; set; }
        public string BilltoCity { get; set; }
        public string BilltoState { get; set; }
        public string BilltoCountry { get; set; }
        public string BilltoPostalCode { get; set; }
        public string ShiptoLine1 { get; set; }
        public string ShiptoLine2 { get; set; }
        public string ShiptoCity { get; set; }
        public string ShiptoState { get; set; }
        public string ShiptoCountry { get; set; }
        public string ShiptoPostalCode { get; set; }

    }
}
