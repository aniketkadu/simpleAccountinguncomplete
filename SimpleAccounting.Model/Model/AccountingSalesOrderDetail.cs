using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Model
{
   public class AccountingSalesOrderDetail : AuditableEntity<long>
    {
        public int SalesOrderDetailId { get; set; }
        public int SalesOrderId { get; set; }
        public virtual AccountingSalesOrder SalesOrderFK { get; set; }
        public int ProductId { get; set; }
        public virtual ICollection<AccountingProduct> SOProductFK { get; set; }
    }
}
