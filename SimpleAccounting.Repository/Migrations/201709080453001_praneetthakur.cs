namespace SimpleAccounting.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class praneetthakur : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountingCompanyDetails",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(nullable: false, maxLength: 200, unicode: false),
                        Registrationno = c.Int(nullable: false),
                        Telephoneno = c.String(nullable: false, maxLength: 15),
                        Email = c.String(nullable: false, maxLength: 30, unicode: false),
                        StartDate = c.DateTime(storeType: "date"),
                        LogoImage = c.Binary(nullable: false, storeType: "image"),
                        Serialno = c.String(maxLength: 8000, unicode: false),
                        BillAddressLine1 = c.String(nullable: false, maxLength: 50, unicode: false),
                        BillAddressLine2 = c.String(maxLength: 50, unicode: false),
                        BillCity = c.String(nullable: false, maxLength: 20, unicode: false),
                        BillState = c.String(nullable: false, maxLength: 20, unicode: false),
                        BillCountry = c.String(nullable: false, maxLength: 20, unicode: false),
                        BillPostalCode = c.String(nullable: false, maxLength: 10, unicode: false),
                        ShipAddressLine1 = c.String(nullable: false, maxLength: 50, unicode: false),
                        ShipAddressLine2 = c.String(nullable: false, maxLength: 50, unicode: false),
                        ShipCity = c.String(nullable: false, maxLength: 20, unicode: false),
                        ShipState = c.String(nullable: false, maxLength: 20, unicode: false),
                        ShipCountry = c.String(nullable: false, maxLength: 20, unicode: false),
                        ShipPostalCode = c.String(nullable: false, maxLength: 10, unicode: false),
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CompanyId);
            
            CreateTable(
                "dbo.AccountingCustomer",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        Active = c.Boolean(nullable: false),
                        Registrationno = c.Int(),
                        BalanceAmt = c.Decimal(storeType: "money"),
                        CustomerType = c.String(nullable: false, maxLength: 20, unicode: false),
                        SalesMan = c.String(nullable: false, maxLength: 50, unicode: false),
                        Telephoneno = c.String(nullable: false, maxLength: 15, unicode: false),
                        Fax = c.String(maxLength: 20, unicode: false),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                        ContactPerson = c.String(nullable: false, maxLength: 50, unicode: false),
                        Remarks = c.String(nullable: false, maxLength: 200, unicode: false),
                        BillAddressLine1 = c.String(nullable: false, maxLength: 50, unicode: false),
                        BillAddressLine2 = c.String(maxLength: 50, unicode: false),
                        BillCity = c.String(nullable: false, maxLength: 50, unicode: false),
                        BillState = c.String(nullable: false, maxLength: 50, unicode: false),
                        BillCountry = c.String(nullable: false, maxLength: 50, unicode: false),
                        BillPostalCode = c.String(nullable: false, maxLength: 20, unicode: false),
                        ShipAddressLine1 = c.String(nullable: false, maxLength: 50, unicode: false),
                        ShipAddressLine2 = c.String(maxLength: 50, unicode: false),
                        ShipCity = c.String(nullable: false, maxLength: 50, unicode: false),
                        ShipState = c.String(nullable: false, maxLength: 50, unicode: false),
                        ShipCountry = c.String(nullable: false, maxLength: 50, unicode: false),
                        ShipPostalCode = c.String(nullable: false, maxLength: 20, unicode: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                        Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.AccountingSalesInvoice",
                c => new
                    {
                        SalesInvoiceId = c.Int(nullable: false),
                        Orderno = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false, storeType: "date"),
                        InvoicePono = c.Int(nullable: false),
                        SupplierName = c.String(maxLength: 50, unicode: false),
                        BillAddressLine1 = c.String(nullable: false, maxLength: 50, unicode: false),
                        ShipAddressLine1 = c.String(nullable: false, maxLength: 50, unicode: false),
                        Amount = c.Decimal(nullable: false, storeType: "money"),
                        TermsCondition = c.String(name: "Terms&Condition", nullable: false, maxLength: 200, unicode: false),
                        CustomerId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                        Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.SalesInvoiceId)
                .ForeignKey("dbo.AccountingSalesInvoiceDetail", t => t.SalesInvoiceId)
                .ForeignKey("dbo.AccountingCustomer", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.SalesInvoiceId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.AccountingSalesInvoiceDetail",
                c => new
                    {
                        SalesInvoiceDetailId = c.Int(nullable: false, identity: true),
                        SalesInvoiceId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                        Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.SalesInvoiceDetailId);
            
            CreateTable(
                "dbo.AccountingProducts",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductCode = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        Quantity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, storeType: "money"),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                        Id = c.Long(nullable: false),
                        ProductPurchaseInvoice_PurchaseInvoiceDetailId = c.Int(nullable: false),
                        ProductPurchaseOrder_PurchaseOrderDetailId = c.Int(nullable: false),
                        ProductSalesInvoice_SalesInvoiceDetailId = c.Int(nullable: false),
                        ProductSalesOrder_SalesOrderDetailId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.AccountingPurchaseInvoiceDetails", t => t.ProductPurchaseInvoice_PurchaseInvoiceDetailId, cascadeDelete: true)
                .ForeignKey("dbo.AccountingPurchaseOrderDetails", t => t.ProductPurchaseOrder_PurchaseOrderDetailId, cascadeDelete: true)
                .ForeignKey("dbo.AccountingSalesInvoiceDetail", t => t.ProductSalesInvoice_SalesInvoiceDetailId, cascadeDelete: true)
                .ForeignKey("dbo.AccountingSalesOrderDetails", t => t.ProductSalesOrder_SalesOrderDetailId, cascadeDelete: true)
                .Index(t => t.ProductPurchaseInvoice_PurchaseInvoiceDetailId)
                .Index(t => t.ProductPurchaseOrder_PurchaseOrderDetailId)
                .Index(t => t.ProductSalesInvoice_SalesInvoiceDetailId)
                .Index(t => t.ProductSalesOrder_SalesOrderDetailId);
            
            CreateTable(
                "dbo.AccountingPurchaseInvoiceDetails",
                c => new
                    {
                        PurchaseInvoiceDetailId = c.Int(nullable: false, identity: true),
                        PurchaseInvoiceId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                        Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.PurchaseInvoiceDetailId);
            
            CreateTable(
                "dbo.AccountingPurchaseInvoice",
                c => new
                    {
                        PurchaseInvoiceId = c.Int(nullable: false),
                        Invoiceno = c.Int(nullable: false),
                        InvoiceDate = c.DateTime(nullable: false, storeType: "date"),
                        InvoicePono = c.Int(nullable: false),
                        SupplierName = c.String(maxLength: 50, unicode: false),
                        BillAddressLine1 = c.String(nullable: false, maxLength: 50, unicode: false),
                        ShipAddressLine1 = c.String(nullable: false, maxLength: 50, unicode: false),
                        Amount = c.Decimal(nullable: false, storeType: "money"),
                        TermsCondition = c.String(name: "Terms&Condition", nullable: false, maxLength: 200, unicode: false),
                        SupplierId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                        Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.PurchaseInvoiceId)
                .ForeignKey("dbo.AccountingSupplier", t => t.SupplierId, cascadeDelete: true)
                .ForeignKey("dbo.AccountingPurchaseInvoiceDetails", t => t.PurchaseInvoiceId)
                .Index(t => t.PurchaseInvoiceId)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.AccountingSupplier",
                c => new
                    {
                        SupplierId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        Active = c.Boolean(nullable: false),
                        Registrationno = c.Int(),
                        BalanceAmt = c.Decimal(storeType: "money"),
                        Telephoneno = c.String(nullable: false, maxLength: 15, unicode: false),
                        Fax = c.String(maxLength: 20, unicode: false),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                        ContactPerson = c.String(nullable: false, maxLength: 50, unicode: false),
                        Remarks = c.String(nullable: false, maxLength: 200, unicode: false),
                        BillAddressLine1 = c.String(nullable: false, maxLength: 50, unicode: false),
                        BillAddressLine2 = c.String(maxLength: 50, unicode: false),
                        BillCity = c.String(nullable: false, maxLength: 50, unicode: false),
                        BillState = c.String(nullable: false, maxLength: 50, unicode: false),
                        BillCountry = c.String(nullable: false, maxLength: 50, unicode: false),
                        BillPostalCode = c.String(nullable: false, maxLength: 20, unicode: false),
                        ShipAddressLine1 = c.String(nullable: false, maxLength: 50, unicode: false),
                        ShipAddressLine2 = c.String(maxLength: 50, unicode: false),
                        ShipCity = c.String(nullable: false, maxLength: 50, unicode: false),
                        ShipState = c.String(nullable: false, maxLength: 50, unicode: false),
                        ShipCountry = c.String(nullable: false, maxLength: 50, unicode: false),
                        ShipPostalCode = c.String(nullable: false, maxLength: 20, unicode: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                        Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.SupplierId);
            
            CreateTable(
                "dbo.AccountingPurchaseOrder",
                c => new
                    {
                        PurchaseOrderId = c.Int(nullable: false),
                        Orderno = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false, storeType: "date"),
                        DeliveryDate = c.DateTime(nullable: false, storeType: "date"),
                        SupplierName = c.String(maxLength: 50, unicode: false),
                        BillAddressLine1 = c.String(nullable: false, maxLength: 50, unicode: false),
                        ShipAddressLine1 = c.String(nullable: false, maxLength: 50, unicode: false),
                        Amount = c.Decimal(nullable: false, storeType: "money"),
                        TermsCondition = c.String(name: "Terms&Condition", nullable: false, maxLength: 200, unicode: false),
                        SupplierId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                        Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.PurchaseOrderId)
                .ForeignKey("dbo.AccountingSupplier", t => t.SupplierId, cascadeDelete: true)
                .ForeignKey("dbo.AccountingPurchaseOrderDetails", t => t.PurchaseOrderId)
                .Index(t => t.PurchaseOrderId)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.AccountingPurchaseOrderDetails",
                c => new
                    {
                        PurchaseOrderDetailId = c.Int(nullable: false, identity: true),
                        PurchaseOrderId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                        Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.PurchaseOrderDetailId);
            
            CreateTable(
                "dbo.AccountingSalesOrderDetails",
                c => new
                    {
                        SalesOrderDetailId = c.Int(nullable: false, identity: true),
                        SalesOrderId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                        Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.SalesOrderDetailId);
            
            CreateTable(
                "dbo.AccountingSalesOrder",
                c => new
                    {
                        SalesOrderId = c.Int(nullable: false),
                        Orderno = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false, storeType: "date"),
                        DeliveryDate = c.DateTime(nullable: false, storeType: "date"),
                        SupplierName = c.String(maxLength: 50, unicode: false),
                        BillAddressLine1 = c.String(nullable: false, maxLength: 50, unicode: false),
                        ShipAddressLine1 = c.String(nullable: false, maxLength: 50, unicode: false),
                        Amount = c.Decimal(nullable: false, storeType: "money"),
                        TermsCondition = c.String(name: "Terms&Condition", nullable: false, maxLength: 200, unicode: false),
                        CustomerId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                        Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.SalesOrderId)
                .ForeignKey("dbo.AccountingCustomer", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.AccountingSalesOrderDetails", t => t.SalesOrderId)
                .Index(t => t.SalesOrderId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.AccountingOptions",
                c => new
                    {
                        OptionId = c.Int(nullable: false, identity: true),
                        DateFormat = c.String(nullable: false, maxLength: 10, unicode: false),
                        CommaFormat = c.String(nullable: false, maxLength: 20, unicode: false),
                        DecimalFormat = c.String(nullable: false, maxLength: 10, unicode: false),
                        CurrencyType = c.String(nullable: false, maxLength: 5, unicode: false),
                        DefaultBankAccount = c.String(nullable: false, maxLength: 20, unicode: false),
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OptionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AccountingSalesInvoice", "CustomerId", "dbo.AccountingCustomer");
            DropForeignKey("dbo.AccountingProducts", "ProductSalesOrder_SalesOrderDetailId", "dbo.AccountingSalesOrderDetails");
            DropForeignKey("dbo.AccountingSalesOrder", "SalesOrderId", "dbo.AccountingSalesOrderDetails");
            DropForeignKey("dbo.AccountingSalesOrder", "CustomerId", "dbo.AccountingCustomer");
            DropForeignKey("dbo.AccountingProducts", "ProductSalesInvoice_SalesInvoiceDetailId", "dbo.AccountingSalesInvoiceDetail");
            DropForeignKey("dbo.AccountingProducts", "ProductPurchaseOrder_PurchaseOrderDetailId", "dbo.AccountingPurchaseOrderDetails");
            DropForeignKey("dbo.AccountingProducts", "ProductPurchaseInvoice_PurchaseInvoiceDetailId", "dbo.AccountingPurchaseInvoiceDetails");
            DropForeignKey("dbo.AccountingPurchaseInvoice", "PurchaseInvoiceId", "dbo.AccountingPurchaseInvoiceDetails");
            DropForeignKey("dbo.AccountingPurchaseInvoice", "SupplierId", "dbo.AccountingSupplier");
            DropForeignKey("dbo.AccountingPurchaseOrder", "PurchaseOrderId", "dbo.AccountingPurchaseOrderDetails");
            DropForeignKey("dbo.AccountingPurchaseOrder", "SupplierId", "dbo.AccountingSupplier");
            DropForeignKey("dbo.AccountingSalesInvoice", "SalesInvoiceId", "dbo.AccountingSalesInvoiceDetail");
            DropIndex("dbo.AccountingSalesOrder", new[] { "CustomerId" });
            DropIndex("dbo.AccountingSalesOrder", new[] { "SalesOrderId" });
            DropIndex("dbo.AccountingPurchaseOrder", new[] { "SupplierId" });
            DropIndex("dbo.AccountingPurchaseOrder", new[] { "PurchaseOrderId" });
            DropIndex("dbo.AccountingPurchaseInvoice", new[] { "SupplierId" });
            DropIndex("dbo.AccountingPurchaseInvoice", new[] { "PurchaseInvoiceId" });
            DropIndex("dbo.AccountingProducts", new[] { "ProductSalesOrder_SalesOrderDetailId" });
            DropIndex("dbo.AccountingProducts", new[] { "ProductSalesInvoice_SalesInvoiceDetailId" });
            DropIndex("dbo.AccountingProducts", new[] { "ProductPurchaseOrder_PurchaseOrderDetailId" });
            DropIndex("dbo.AccountingProducts", new[] { "ProductPurchaseInvoice_PurchaseInvoiceDetailId" });
            DropIndex("dbo.AccountingSalesInvoice", new[] { "CustomerId" });
            DropIndex("dbo.AccountingSalesInvoice", new[] { "SalesInvoiceId" });
            DropTable("dbo.AccountingOptions");
            DropTable("dbo.AccountingSalesOrder");
            DropTable("dbo.AccountingSalesOrderDetails");
            DropTable("dbo.AccountingPurchaseOrderDetails");
            DropTable("dbo.AccountingPurchaseOrder");
            DropTable("dbo.AccountingSupplier");
            DropTable("dbo.AccountingPurchaseInvoice");
            DropTable("dbo.AccountingPurchaseInvoiceDetails");
            DropTable("dbo.AccountingProducts");
            DropTable("dbo.AccountingSalesInvoiceDetail");
            DropTable("dbo.AccountingSalesInvoice");
            DropTable("dbo.AccountingCustomer");
            DropTable("dbo.AccountingCompanyDetails");
        }
    }
}
