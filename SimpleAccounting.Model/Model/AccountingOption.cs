using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Model
{
   public class AccountingOption: AuditableEntity<long>
    {
        public int OptionId { get; set; }
        public string OptionDate { get; set; }
        public string OptionCommas { get; set; }
        public string OptionDecPlaces { get; set; }
        public string OptionCurrencyName { get; set; }
        public string DefaultCashorBankAcc { get; set; }
    }
}
