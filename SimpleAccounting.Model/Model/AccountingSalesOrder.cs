﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Model
{
   public class AccountingSalesOrder : AuditableEntity<long>
    {
        public int SalesOrderId { get; set; }
        public int SalesOrderNo { get; set; }
        public DateTime SalesOrderDate { get; set; }
        public DateTime SalesOrderDeliveryDate { get; set; }
        public string SalesCustomerName { get; set; }
        public string SalesOrderBillToLine1 { get; set; }
        public string SalesOrderShipToLine1 { get; set; }
        public decimal SalesProductAmt { get; set; }
        public string SalesTandC { get; set; }
        //foreign key
        public int CustomerId { get; set; }
        public virtual AccountingCustomer SOCustomer { get; set; }
        //public virtual ICollection<AccountingSalesOrderDetail> SalesOrderDetail { get; private set; }
        public virtual AccountingSalesOrderDetail SalesOrderDetail { get; set; }

    }
}
