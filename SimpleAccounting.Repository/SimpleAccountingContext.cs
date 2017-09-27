using SimpleAccounting.Model;
using SimpleAccounting.Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleAccounting.Repository
{
    /// <summary>
    /// this interface is  for creating tables
    /// </summary>


    public interface ISimpleAccountingContext
    {

        IDbSet<AccountingCompanyDetail> AccountingCompanyDetails { get; set; }
        IDbSet<AccountingCustomer> AccountingCustomers { get; set; }

        IDbSet<AccountingOption> AccountingOptions { get; set; }
        IDbSet<AccountingProduct> AccountingProducts { get; set; }
        IDbSet<AccountingPurchaseInvoice> AccountingPurchaseInvoices { get; set; }

        IDbSet<AccountingPurchaseInvoiceDetail> AccountingPurchaseInvoiceDetails { get; set; }
        IDbSet<AccountingPurchaseOrder> AccountingPurchaseOrders { get; set; }


        IDbSet<AccountingPurchaseOrderDetail> AccountingPurchaseOrderDetail { get; set; }
        IDbSet<AccountingLogin> AccountingLogins { get; set; }
        IDbSet<AccountingSalesInvoice> AccountingSalesInvoices { get; set; }
        IDbSet<AccountingSalesInvoiceDetail> AccountingSalesInvoiceDetails { get; set; }
        IDbSet<AccountingSalesOrder> AccountingSalesOrder { get; set; }
        IDbSet<AccountingSalesOrderDetail> AccountingSalesOrderDetails { get; set; }
        //IDbSet<AccountingSalesQuotation> AccountingSalesQuotations { get; set; }
        IDbSet<AccountingSupplier> AccountingSuppliers { get; set; }




        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        int SaveChanges();
    }

    /// <summary>
    /// this class will implement ISimpleAccountingContext for database operations
    /// </summary>


    public class SimpleAccountingContext : DbContext, ISimpleAccountingContext
    {
        public SimpleAccountingContext() : base("name=MyConnectionString")
        {

        }

        public static SimpleAccountingContext Create()
        {
            return new SimpleAccountingContext();
        }
        public IDbSet<AccountingCompanyDetail> AccountingCompanyDetails
        {
            get;

            set;
        }

        public IDbSet<AccountingCustomer> AccountingCustomers
        {
            get;

            set;
        }

        public IDbSet<AccountingOption> AccountingOptions
        {
            get;

            set;
        }

        public IDbSet<AccountingPurchaseInvoice> AccountingPurchaseInvoices
        {
            get;

            set;
        }

        public IDbSet<AccountingPurchaseOrder> AccountingPurchaseOrders
        {
            get;

            set;
        }



      /*  public IDbSet<AccountingPurchaseQuotation> AccountingPurchaseQuotations
        {
            get;

            set;
        }*/

        public IDbSet<AccountingProduct> AccountingProducts
        {
            get;

            set;
        }


        public IDbSet<AccountingSalesInvoice> AccountingSalesInvoices
        {
            get;

            set;
        }

        public IDbSet<AccountingSalesOrder> AccountingSalesOrder
        {
            get;

            set;
        }


        public IDbSet<AccountingSupplier> AccountingSuppliers
        {
            get;

            set;
        }

        public IDbSet<AccountingPurchaseInvoiceDetail> AccountingPurchaseInvoiceDetails
        {
            get;

            set;
        }

        public IDbSet<AccountingPurchaseOrderDetail> AccountingPurchaseOrderDetail
        {
            get;

            set;
        }

        public IDbSet<AccountingSalesInvoiceDetail> AccountingSalesInvoiceDetails
        {
            get;

            set;
        }

        public IDbSet<AccountingSalesOrderDetail> AccountingSalesOrderDetails
        {
            get;

            set;
        }

        public IDbSet<AccountingLogin> AccountingLogins
        {
            get;

            set;
        }

        /// <summary>
        /// For making changes in database
        /// </summary>
        /// <returns></returns>

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
            #region<--Table AccountingCompany-->

            modelBuilder.Entity<AccountingCompanyDetail>()
                .ToTable("AccountingCompanyDetails")
                .HasKey(c => c.CompanyId);

            modelBuilder.Entity<AccountingCompanyDetail>()
                .Property(c => c.CompanyName)
                .HasColumnName("CompanyName")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsOptional();

            modelBuilder.Entity<AccountingCompanyDetail>()
                .Property(c => c.CompanyRegno)
                .HasColumnName("Registrationno")
                .HasColumnType("int")
                .IsOptional();

            modelBuilder.Entity<AccountingCompanyDetail>()
                .Property(c => c.CompanyTelephone)
                .HasColumnName("Telephoneno")
                .HasColumnType("nvarchar")
                .HasMaxLength(15)
                .IsOptional();

            modelBuilder.Entity<AccountingCompanyDetail>()
                .Property(c => c.CompanyEmail)
                .HasColumnName("Email")
                .HasColumnType("varchar")
                .HasMaxLength(30)
                .IsOptional();

            modelBuilder.Entity<AccountingCompanyDetail>()
                .Property(c => c.FinancialYrStartDate)
                .HasColumnName("StartDate")
                .HasColumnType("date")
                .IsOptional();

            modelBuilder.Entity<AccountingCompanyDetail>()
                .Property(c => c.CompanyLogo)
                .HasColumnName("LogoImage")
                .HasColumnType("Image")
                .IsOptional();

            modelBuilder.Entity<AccountingCompanyDetail>()
                .Property(c => c.SoftwareSerialNo)
                .HasColumnName("Serialno")
                .HasColumnType("varchar")
                .IsOptional();

            modelBuilder.Entity<AccountingCompanyDetail>()
                .Property(c => c.BilltoLine1)
                .HasColumnName("BillAddressLine1")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsOptional();

            modelBuilder.Entity<AccountingCompanyDetail>()
                .Property(c => c.BilltoLine2)
                .HasColumnName("BillAddressLine2")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsOptional();

            modelBuilder.Entity<AccountingCompanyDetail>()
                .Property(c => c.BilltoCity)
                .HasColumnName("BillCity")
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsOptional();

            modelBuilder.Entity<AccountingCompanyDetail>()
                .Property(c => c.BilltoState)
                .HasColumnName("BillState")
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsOptional();

            modelBuilder.Entity<AccountingCompanyDetail>()
              .Property(c => c.BilltoCountry)
              .HasColumnName("BillCountry")
              .HasColumnType("varchar")
              .HasMaxLength(20)
              .IsOptional();

            modelBuilder.Entity<AccountingCompanyDetail>()
              .Property(c => c.BilltoPostalCode)
              .HasColumnName("BillPostalCode")
              .HasColumnType("varchar")
              .HasMaxLength(10)
              .IsOptional();

            modelBuilder.Entity<AccountingCompanyDetail>()
              .Property(c => c.ShiptoLine1)
              .HasColumnName("ShipAddressLine1")
              .HasColumnType("varchar")
              .HasMaxLength(50)
              .IsOptional();

            modelBuilder.Entity<AccountingCompanyDetail>()
              .Property(c => c.ShiptoLine2)
              .HasColumnName("ShipAddressLine2")
              .HasColumnType("varchar")
              .HasMaxLength(50)
              .IsOptional();

            modelBuilder.Entity<AccountingCompanyDetail>()
              .Property(c => c.ShiptoCity)
              .HasColumnName("ShipCity")
              .HasColumnType("varchar")
              .HasMaxLength(20)
              .IsOptional();

            modelBuilder.Entity<AccountingCompanyDetail>()
              .Property(c => c.ShiptoState)
              .HasColumnName("ShipState")
              .HasColumnType("varchar")
              .HasMaxLength(20)
              .IsOptional();

            modelBuilder.Entity<AccountingCompanyDetail>()
              .Property(c => c.ShiptoCountry)
              .HasColumnName("ShipCountry")
              .HasColumnType("varchar")
              .HasMaxLength(20)
              .IsOptional();

            modelBuilder.Entity<AccountingCompanyDetail>()
              .Property(c => c.ShiptoPostalCode)
              .HasColumnName("ShipPostalCode")
                .HasColumnType("varchar")
                .HasMaxLength(10)
                .IsOptional();

            #endregion

            #region<--Table AccountingCustomer-->

            modelBuilder.Entity<AccountingCustomer>()
                .ToTable("AccountingCustomer")
                .HasKey(c => c.CustomerId);

            modelBuilder.Entity<AccountingCustomer>()
                .Property(c => c.CustomerName)
                .HasColumnType("varchar")
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsOptional();

            modelBuilder.Entity<AccountingCustomer>()
               .Property(c => c.CustomerInActive)
               .HasColumnName("Active")
               .HasColumnType("bit");

            modelBuilder.Entity<AccountingCustomer>()
               .Property(c => c.CustomerCompanyRegno)
               .HasColumnName("Registrationno")
               .HasColumnType("int")
               .IsOptional();

            modelBuilder.Entity<AccountingCustomer>()
               .Property(c => c.CustomerBalanceAmt)
               .HasColumnName("BalanceAmt")
               .HasColumnType("money")
               .IsOptional();

            modelBuilder.Entity<AccountingCustomer>()
               .Property(c => c.CustomerType)
               .HasColumnType("varchar")
               .HasColumnName("CustomerType")
               .HasMaxLength(20)
               .IsOptional();

            modelBuilder.Entity<AccountingCustomer>()
               .Property(c => c.Salesman)
               .HasColumnName("SalesMan")
               .HasColumnType("varchar")
               .HasMaxLength(50)
               .IsOptional();

            modelBuilder.Entity<AccountingCustomer>()
               .Property(c => c.CustomerTelephone)
               .HasColumnName("Telephoneno")
               .HasColumnType("varchar")
               .HasMaxLength(15)
               .IsOptional();

            modelBuilder.Entity<AccountingCustomer>()
               .Property(c => c.CustomerFax)
               .HasColumnName("Fax")
               .HasColumnType("varchar")
               .HasMaxLength(20)
               .IsOptional();

            modelBuilder.Entity<AccountingCustomer>()
               .Property(c => c.CustomerEmail)
               .HasColumnName("Email")
               .HasColumnType("varchar")
               .HasMaxLength(50)
               .IsOptional();

            modelBuilder.Entity<AccountingCustomer>()
               .Property(c => c.CustomerContactPerson)
               .HasColumnType("varchar")
               .HasColumnName("ContactPerson")
               .HasMaxLength(50)
               .IsOptional();

            modelBuilder.Entity<AccountingCustomer>()
               .Property(c => c.CustomerRemarks)
               .HasColumnName("Remarks")
               .HasColumnType("varchar")
               .HasMaxLength(200)
               .IsOptional();

            modelBuilder.Entity<AccountingCustomer>()
               .Property(c => c.CustomerBilltoLine1)
               .HasColumnName("BillAddressLine1")
               .HasColumnType("varchar")
               .HasMaxLength(50)
               .IsOptional();

            modelBuilder.Entity<AccountingCustomer>()
               .Property(c => c.CustomerBilltoLine2)
               .HasColumnName("BillAddressLine2")
               .HasColumnType("varchar")
               .HasMaxLength(50)
               .IsOptional();

            modelBuilder.Entity<AccountingCustomer>()
               .Property(c => c.CustomerBilltoCity)
               .HasColumnName("BillCity")
               .HasColumnType("varchar")
               .HasMaxLength(50)
               .IsOptional();

            modelBuilder.Entity<AccountingCustomer>()
               .Property(c => c.CustomerBilltoState)
               .HasColumnName("BillState")
               .HasColumnType("varchar")
               .HasMaxLength(50)
               .IsOptional();

            modelBuilder.Entity<AccountingCustomer>()
               .Property(c => c.CustomerBilltoCountry)
               .HasColumnName("BillCountry")
               .HasColumnType("varchar")
               .HasMaxLength(50)
               .IsOptional();

            modelBuilder.Entity<AccountingCustomer>()
               .Property(c => c.CustomerBilltoPostalCode)
               .HasColumnType("varchar")
               .HasColumnName("BillPostalCode")
               .HasMaxLength(20)
               .IsOptional();

            modelBuilder.Entity<AccountingCustomer>()
               .Property(c => c.CustomerShiptoLine1)
               .HasColumnType("varchar")
               .HasColumnName("ShipAddressLine1")
               .HasMaxLength(50)
               .IsOptional();

            modelBuilder.Entity<AccountingCustomer>()
               .Property(c => c.CustomerShiptoLine2)
               .HasColumnName("ShipAddressLine2")
               .HasColumnType("varchar")
               .HasMaxLength(50)
               .IsOptional();

            modelBuilder.Entity<AccountingCustomer>()
               .Property(c => c.CustomerShiptoCity)
               .HasColumnName("ShipCity")
               .HasColumnType("varchar")
               .HasMaxLength(50)
               .IsOptional();

            modelBuilder.Entity<AccountingCustomer>()
               .Property(c => c.CustomerShiptoState)
               .HasColumnType("varchar")
               .HasColumnName("ShipState")
               .HasMaxLength(50)
               .IsOptional();

            modelBuilder.Entity<AccountingCustomer>()
               .Property(c => c.CustomerShiptoCountry)
               .HasColumnType("varchar")
               .HasColumnName("ShipCountry")
               .HasMaxLength(50)
               .IsOptional();

            modelBuilder.Entity<AccountingCustomer>()
               .Property(c => c.CustomerShiptoPostalCode)
               .HasColumnType("varchar")
               .HasColumnName("ShipPostalCode")
               .HasMaxLength(20)
               .IsOptional();
            #endregion

            #region<--Table AccountingSupplier-->
            modelBuilder.Entity<AccountingSupplier>()
                .ToTable("AccountingSupplier")
                .HasKey(c => c.SupplierId);

            modelBuilder.Entity<AccountingSupplier>()
                .Property(c => c.SupplierName)
                .HasColumnType("varchar")
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsOptional();

            modelBuilder.Entity<AccountingSupplier>()
               .Property(c => c.SupplierInActive)
               .HasColumnName("Active")
               .HasColumnType("bit");

            modelBuilder.Entity<AccountingSupplier>()
               .Property(c => c.SupplierCompanyRegno)
               .HasColumnName("Registrationno")
               .HasColumnType("int")
               .IsOptional();

            modelBuilder.Entity<AccountingSupplier>()
               .Property(c => c.SupplierBalanceAmt)
               .HasColumnName("BalanceAmt")
               .HasColumnType("money")
               .IsOptional();

            modelBuilder.Entity<AccountingSupplier>()
               .Property(c => c.SupplierTelephone)
               .HasColumnName("Telephoneno")
               .HasColumnType("varchar")
               .HasMaxLength(15)
               .IsOptional();

            modelBuilder.Entity<AccountingSupplier>()
               .Property(c => c.SupplierFax)
               .HasColumnName("Fax")
               .HasColumnType("varchar")
               .HasMaxLength(20)
               .IsOptional();

            modelBuilder.Entity<AccountingSupplier>()
               .Property(c => c.SupplierEmail)
               .HasColumnName("Email")
               .HasColumnType("varchar")
               .HasMaxLength(50)
               .IsOptional();

            modelBuilder.Entity<AccountingSupplier>()
               .Property(c => c.SupplierContactPerson)
               .HasColumnType("varchar")
               .HasColumnName("ContactPerson")
               .HasMaxLength(50)
               .IsOptional();

            modelBuilder.Entity<AccountingSupplier>()
               .Property(c => c.SupplierRemarks)
               .HasColumnName("Remarks")
               .HasColumnType("varchar")
               .HasMaxLength(200)
               .IsOptional();

            modelBuilder.Entity<AccountingSupplier>()
               .Property(c => c.SupplierBilltoLine1)
               .HasColumnName("BillAddressLine1")
               .HasColumnType("varchar")
               .HasMaxLength(50)
               .IsOptional();

            modelBuilder.Entity<AccountingSupplier>()
               .Property(c => c.SupplierBilltoLine2)
               .HasColumnName("BillAddressLine2")
               .HasColumnType("varchar")
               .HasMaxLength(50)
               .IsOptional();

            modelBuilder.Entity<AccountingSupplier>()
               .Property(c => c.SupplierBilltoCity)
               .HasColumnName("BillCity")
               .HasColumnType("varchar")
               .HasMaxLength(50)
               .IsOptional();

            modelBuilder.Entity<AccountingSupplier>()
               .Property(c => c.SupplierBilltoState)
               .HasColumnName("BillState")
               .HasColumnType("varchar")
               .HasMaxLength(50)
               .IsOptional();

            modelBuilder.Entity<AccountingSupplier>()
               .Property(c => c.SupplierBilltoCountry)
               .HasColumnName("BillCountry")
               .HasColumnType("varchar")
               .HasMaxLength(50)
               .IsOptional();

            modelBuilder.Entity<AccountingSupplier>()
               .Property(c => c.SupplierBilltoPostalCode)
               .HasColumnType("varchar")
               .HasColumnName("BillPostalCode")
               .HasMaxLength(20)
               .IsOptional();

            modelBuilder.Entity<AccountingSupplier>()
               .Property(c => c.SupplierShiptoLine1)
               .HasColumnType("varchar")
               .HasColumnName("ShipAddressLine1")
               .HasMaxLength(50)
               .IsOptional();

            modelBuilder.Entity<AccountingSupplier>()
               .Property(c => c.SupplierShiptoLine2)
               .HasColumnName("ShipAddressLine2")
               .HasColumnType("varchar")
               .HasMaxLength(50)
               .IsOptional();

            modelBuilder.Entity<AccountingSupplier>()
               .Property(c => c.SupplierShiptoCity)
               .HasColumnName("ShipCity")
               .HasColumnType("varchar")
               .HasMaxLength(50)
               .IsOptional();

            modelBuilder.Entity<AccountingSupplier>()
               .Property(c => c.SupplierShiptoState)
               .HasColumnType("varchar")
               .HasColumnName("ShipState")
               .HasMaxLength(50)
               .IsOptional();

            modelBuilder.Entity<AccountingSupplier>()
               .Property(c => c.SupplierShiptoCountry)
               .HasColumnType("varchar")
               .HasColumnName("ShipCountry")
               .HasMaxLength(50)
               .IsOptional();

            modelBuilder.Entity<AccountingSupplier>()
               .Property(c => c.SupplierShiptoPostalCode)
               .HasColumnType("varchar")
               .HasColumnName("ShipPostalCode")
               .HasMaxLength(20)
               .IsOptional();
            #endregion

            #region<--AccountingOptions-->
            modelBuilder.Entity<AccountingOption>()
                .ToTable("AccountingOptions")
                .HasKey(o => o.OptionId);

            modelBuilder.Entity<AccountingOption>()
                .Property(o => o.OptionDate)
                .HasColumnName("DateFormat")
                .HasColumnType("varchar")
                .HasMaxLength(10)
                .IsOptional();

            modelBuilder.Entity<AccountingOption>()
                .Property(o => o.OptionCommas)
                .HasColumnName("CommaFormat")
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsOptional();

            modelBuilder.Entity<AccountingOption>()
               .Property(o => o.OptionDecPlaces)
               .HasColumnName("DecimalFormat")
               .HasColumnType("varchar")
               .HasMaxLength(10)
               .IsOptional();

            modelBuilder.Entity<AccountingOption>()
               .Property(o => o.OptionCurrencyName)
               .HasColumnName("CurrencyType")
               .HasColumnType("varchar")
               .HasMaxLength(5)
               .IsOptional();

            modelBuilder.Entity<AccountingOption>()
               .Property(o => o.DefaultCashorBankAcc)
               .HasColumnName("DefaultBankAccount")
               .HasColumnType("varchar")
               .HasMaxLength(20)
               .IsOptional();
            #endregion

            #region<--AccountingProduct-->

            modelBuilder.Entity<AccountingProduct>()
                .ToTable("AccountingProducts")
                .HasKey(p => p.ProductId);

            modelBuilder.Entity<AccountingProduct>()
                .Property(p => p.ProductCode)
                .HasColumnName("ProductCode")
                .HasColumnType("int")
                .IsOptional();

            modelBuilder.Entity<AccountingProduct>()
                .Property(p => p.ProductName)
                .HasColumnName("Name")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsOptional();

            modelBuilder.Entity<AccountingProduct>()
                .Property(p => p.ProductQty)
                .HasColumnName("Quantity")
                .HasColumnType("int")
                .IsOptional();

            modelBuilder.Entity<AccountingProduct>()
                .Property(p => p.ProductPrice)
                .HasColumnName("Price")
                .HasColumnType("money")
                .IsOptional();

            modelBuilder.Entity<AccountingProduct>()
                .Property(p => p.ProductDiscount)
                .HasColumnName("Discount")
                .HasColumnType("decimal")
                .IsOptional();

            #endregion

            #region<--AccountingPurchaseInvoice-->

            modelBuilder.Entity<AccountingPurchaseInvoice>()
                .ToTable("AccountingPurchaseInvoice")
                .HasKey(po => po.PurchaseInvoiceId);

            modelBuilder.Entity<AccountingPurchaseInvoice>()
                .Property(po => po.PurchaseInvoiceNo)
                .HasColumnName("Invoiceno")
                .HasColumnType("int")
                .IsOptional();

            modelBuilder.Entity<AccountingPurchaseInvoice>()
                .Property(po => po.PurchaseInvoiceDate)
                .HasColumnName("InvoiceDate")
                .HasColumnType("date")
                .IsOptional();

            modelBuilder.Entity<AccountingPurchaseInvoice>()
                .Property(po => po.PurchaseInvoicePOno)
                .HasColumnName("InvoicePono")
                .HasColumnType("int")
                .IsOptional();

            modelBuilder.Entity<AccountingPurchaseInvoice>()
                .Property(po => po.PurchaseSupplierName)
                .HasColumnName("SupplierName")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsOptional();

            modelBuilder.Entity<AccountingPurchaseInvoice>()
                .Property(po => po.PurchaseInvoiceBillToLine1)
                .HasColumnName("BillAddressLine1")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsOptional();

            modelBuilder.Entity<AccountingPurchaseInvoice>()
               .Property(po => po.PurchaseInvoiceShipToLine1)
               .HasColumnName("ShipAddressLine1")
               .HasColumnType("varchar")
               .HasMaxLength(50)
               .IsOptional();

            modelBuilder.Entity<AccountingPurchaseInvoice>()
                .Property(po => po.PurchaseProductAmt)
                .HasColumnName("Amount")
                .HasColumnType("money")
                .IsOptional();

            modelBuilder.Entity<AccountingPurchaseInvoice>()
                .Property(po => po.PurchaseTandC)
                .HasColumnName("Terms&Condition")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsOptional();

            #endregion

            #region<--AccountingPurchaseOrder-->

            modelBuilder.Entity<AccountingPurchaseOrder>()
                .ToTable("AccountingPurchaseOrder")
                .HasKey(po => po.PurchaseOrderId);

            modelBuilder.Entity<AccountingPurchaseOrder>()
                .Property(po => po.PurchaseOrderNo)
                .HasColumnName("Orderno")
                .HasColumnType("int")
                .IsOptional();

            modelBuilder.Entity<AccountingPurchaseOrder>()
                .Property(po => po.PurchaseOrderDate)
                .HasColumnName("OrderDate")
                .HasColumnType("date")
                .IsOptional();

            modelBuilder.Entity<AccountingPurchaseOrder>()
                .Property(po => po.PurchaseOrderDeliveryDate)
                .HasColumnName("DeliveryDate")
                .HasColumnType("Date")
                .IsOptional();

            modelBuilder.Entity<AccountingPurchaseOrder>()
                .Property(po => po.PurchaseSupplierName)
                .HasColumnName("SupplierName")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsOptional();

            modelBuilder.Entity<AccountingPurchaseOrder>()
                .Property(po => po.PurchaseOrderBillToLine1)
                .HasColumnName("BillAddressLine1")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsOptional();

            modelBuilder.Entity<AccountingPurchaseOrder>()
               .Property(po => po.PurchaseOrderShipToLine1)
               .HasColumnName("ShipAddressLine1")
               .HasColumnType("varchar")
               .HasMaxLength(50)
               .IsOptional();

            modelBuilder.Entity<AccountingPurchaseOrder>()
                .Property(po => po.PurchaseProductAmt)
                .HasColumnName("Amount")
                .HasColumnType("money")
                .IsOptional();

            modelBuilder.Entity<AccountingPurchaseOrder>()
                .Property(po => po.PurchaseTandC)
                .HasColumnName("Terms&Condition")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsOptional();

            #endregion

            #region<--AccountingSalesInvoice-->

            modelBuilder.Entity<AccountingSalesInvoice>()
                .ToTable("AccountingSalesInvoice")
                .HasKey(po => po.SalesInvoiceId);

            modelBuilder.Entity<AccountingSalesInvoice>()
                .Property(po => po.SalesInvoiceNo)
                .HasColumnName("Orderno")
                .HasColumnType("int")
                .IsOptional();

            modelBuilder.Entity<AccountingSalesInvoice>()
                .Property(po => po.SalesInvoiceDate)
                .HasColumnName("OrderDate")
                .HasColumnType("date")
                .IsOptional();

            modelBuilder.Entity<AccountingSalesInvoice>()
                .Property(po => po.SalesInvoicePOno)
                .HasColumnName("InvoicePono")
                .HasColumnType("int")
                .IsOptional();

            modelBuilder.Entity<AccountingSalesInvoice>()
                .Property(po => po.SalesCustomerName)
                .HasColumnName("SupplierName")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsOptional();

            modelBuilder.Entity<AccountingSalesInvoice>()
                .Property(po => po.SalesInvoiceBillToLine1)
                .HasColumnName("BillAddressLine1")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsOptional();

            modelBuilder.Entity<AccountingSalesInvoice>()
               .Property(po => po.SalesInvoiceShipToLine1)
               .HasColumnName("ShipAddressLine1")
               .HasColumnType("varchar")
               .HasMaxLength(50)
               .IsOptional();

            modelBuilder.Entity<AccountingSalesInvoice>()
                .Property(po => po.SalesProductAmt)
                .HasColumnName("Amount")
                .HasColumnType("money")
                .IsOptional();

            modelBuilder.Entity<AccountingSalesInvoice>()
                .Property(po => po.SalesTandC)
                .HasColumnName("Terms&Condition")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsOptional();

            #endregion

            #region<--AccountingSalesOrder-->

            modelBuilder.Entity<AccountingSalesOrder>()
                .ToTable("AccountingSalesOrder")
                .HasKey(po => po.SalesOrderId);

            modelBuilder.Entity<AccountingSalesOrder>()
                .Property(po => po.SalesOrderNo)
                .HasColumnName("Orderno")
                .HasColumnType("int")
                .IsOptional();

            modelBuilder.Entity<AccountingSalesOrder>()
                .Property(po => po.SalesOrderDate)
                .HasColumnName("OrderDate")
                .HasColumnType("date")
                .IsOptional();

            modelBuilder.Entity<AccountingSalesOrder>()
                .Property(po => po.SalesOrderDeliveryDate)
                .HasColumnName("DeliveryDate")
                .HasColumnType("Date")
                .IsOptional();

            modelBuilder.Entity<AccountingSalesOrder>()
                .Property(po => po.SalesCustomerName)
                .HasColumnName("SupplierName")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsOptional();

            modelBuilder.Entity<AccountingSalesOrder>()
                .Property(po => po.SalesOrderBillToLine1)
                .HasColumnName("BillAddressLine1")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsOptional();

            modelBuilder.Entity<AccountingSalesOrder>()
               .Property(po => po.SalesOrderShipToLine1)
               .HasColumnName("ShipAddressLine1")
               .HasColumnType("varchar")
               .HasMaxLength(50)
               .IsOptional();

            modelBuilder.Entity<AccountingSalesOrder>()
                .Property(po => po.SalesProductAmt)
                .HasColumnName("Amount")
                .HasColumnType("money")
                .IsOptional();

            modelBuilder.Entity<AccountingSalesOrder>()
                .Property(po => po.SalesTandC)
                .HasColumnName("Terms&Condition")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsOptional();

            #endregion

            #region<--AccountingPurchaseOrderDetail-->
            modelBuilder.Entity<AccountingPurchaseOrderDetail>()
               .ToTable("AccountingPurchaseOrderDetails")
               .HasKey(po => po.PurchaseOrderDetailId);

            #endregion

            #region<--AccountingSalesOrderDetail-->
            modelBuilder.Entity<AccountingSalesOrderDetail>()
               .ToTable("AccountingSalesOrderDetails")
               .HasKey(po => po.SalesOrderDetailId);
            #endregion

            #region<--AccountingPurchaseInvoiceDetail-->
            modelBuilder.Entity<AccountingPurchaseInvoiceDetail>()
               .ToTable("AccountingPurchaseInvoiceDetails")
               .HasKey(po => po.PurchaseInvoiceDetailId);
            #endregion

            #region<--AccountingSalesInvoiceDetail-->
            modelBuilder.Entity<AccountingSalesInvoiceDetail>()
               .ToTable("AccountingSalesInvoiceDetail")
               .HasKey(po => po.SalesInvoiceDetailId);

            #endregion

            modelBuilder.Entity<AccountingSalesOrder>()
                .HasRequired(t => t.SOCustomer)
                .WithMany(t => t.CustomerSalesOrder)
                .HasForeignKey(d => d.CustomerId);

            modelBuilder.Entity<AccountingSalesInvoice>()
               .HasRequired(t => t.SICustomer)
               .WithMany(t => t.CustomerSalesInvoice)
               .HasForeignKey(d => d.CustomerId);

            modelBuilder.Entity<AccountingPurchaseOrder>()
               .HasRequired(t => t.POSupplier)
               .WithMany(t => t.SupplierPurchaseOrder)
               .HasForeignKey(d => d.SupplierId);

            modelBuilder.Entity<AccountingPurchaseInvoice>()
               .HasRequired(t => t.PISupplier)
               .WithMany(t => t.SupplierPurchaseInvoice)
               .HasForeignKey(d => d.SupplierId);

            modelBuilder.Entity<AccountingPurchaseInvoiceDetail>()
                .HasRequired(t => t.PurchaseInvoiceFK)
                .WithRequiredPrincipal(t => t.PurchaseInvoiceDetail);

            modelBuilder.Entity<AccountingPurchaseOrderDetail>()
               .HasRequired(t => t.PurchaseOrderFK)
               .WithRequiredPrincipal(t => t.PurchaseOrderDetail);

            modelBuilder.Entity<AccountingSalesInvoiceDetail>()
               .HasRequired(t => t.SalesInvoiceFK)
               .WithRequiredPrincipal(t => t.SalesInvoiceDetail);

            modelBuilder.Entity<AccountingSalesOrderDetail>()
               .HasRequired(t => t.SalesOrderFK)
               .WithRequiredPrincipal(t => t.SalesOrderDetail);


            modelBuilder.Entity<AccountingProduct>()
                 .HasRequired(t => t.ProductPurchaseInvoice)
                 .WithMany(t => t.PIProductFK);


            modelBuilder.Entity<AccountingProduct>()
               .HasRequired(t => t.ProductPurchaseOrder)
               .WithMany(t => t.POProductFK);


            modelBuilder.Entity<AccountingProduct>()
              .HasRequired(t => t.ProductSalesInvoice)
              .WithMany(t => t.SIProductFK);


            modelBuilder.Entity<AccountingProduct>()
              .HasRequired(t => t.ProductSalesOrder)
              .WithMany(t => t.SOProductFK);
        }

        
        public override int SaveChanges()
        {
            var modifiedEntries = ChangeTracker.Entries()
                .Where(x => x.Entity is IAuditableEntity
                    && (x.State == System.Data.Entity.EntityState.Added || x.State == System.Data.Entity.EntityState.Modified));

            foreach (var entry in modifiedEntries)
            {
                IAuditableEntity entity = entry.Entity as IAuditableEntity;
                if (entity != null)
                {
                    string identityName = Thread.CurrentPrincipal.Identity.Name;
                    DateTime now = DateTime.UtcNow;

                    if (entry.State == System.Data.Entity.EntityState.Added)
                    {
                        entity.CreatedBy = identityName;
                        entity.CreatedDate = now;
                    }
                    else
                    {
                        base.Entry(entity).Property(x => x.CreatedBy).IsModified = false;
                        base.Entry(entity).Property(x => x.CreatedDate).IsModified = false;
                    }

                    entity.UpdatedBy = identityName;
                    entity.UpdatedDate = now;
                }
            }

            return base.SaveChanges();
        }

        public void Commit()
        {
            base.SaveChanges();
        }

    }

}

