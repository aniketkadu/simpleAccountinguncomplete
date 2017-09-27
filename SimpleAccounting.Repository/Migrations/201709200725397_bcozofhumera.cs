namespace SimpleAccounting.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bcozofhumera : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.AccountingSalesOrder", name: "CustomerName", newName: "SupplierName");
            CreateTable(
                "dbo.AccountingLogin",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            AddColumn("dbo.AccountingOptions", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AccountingOptions", "CreatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.AccountingOptions", "UpdatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AccountingOptions", "UpdatedBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.AccountingCompanyDetails", "CompanyName", c => c.String(maxLength: 200, unicode: false));
            AlterColumn("dbo.AccountingCompanyDetails", "Registrationno", c => c.Int());
            AlterColumn("dbo.AccountingCompanyDetails", "Telephoneno", c => c.String(maxLength: 15));
            AlterColumn("dbo.AccountingCompanyDetails", "Email", c => c.String(maxLength: 30, unicode: false));
            AlterColumn("dbo.AccountingCompanyDetails", "BillAddressLine1", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingCompanyDetails", "BillCity", c => c.String(maxLength: 20, unicode: false));
            AlterColumn("dbo.AccountingCompanyDetails", "BillState", c => c.String(maxLength: 20, unicode: false));
            AlterColumn("dbo.AccountingCompanyDetails", "BillCountry", c => c.String(maxLength: 20, unicode: false));
            AlterColumn("dbo.AccountingCompanyDetails", "BillPostalCode", c => c.String(maxLength: 10, unicode: false));
            AlterColumn("dbo.AccountingCompanyDetails", "ShipAddressLine1", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingCompanyDetails", "ShipAddressLine2", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingCompanyDetails", "ShipCity", c => c.String(maxLength: 20, unicode: false));
            AlterColumn("dbo.AccountingCompanyDetails", "ShipState", c => c.String(maxLength: 20, unicode: false));
            AlterColumn("dbo.AccountingCompanyDetails", "ShipCountry", c => c.String(maxLength: 20, unicode: false));
            AlterColumn("dbo.AccountingCompanyDetails", "ShipPostalCode", c => c.String(maxLength: 10, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "Name", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "CustomerType", c => c.String(maxLength: 20, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "SalesMan", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "Telephoneno", c => c.String(maxLength: 15, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "Email", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "ContactPerson", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "Remarks", c => c.String(maxLength: 200, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "BillAddressLine1", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "BillCity", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "BillState", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "BillCountry", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "BillPostalCode", c => c.String(maxLength: 20, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "ShipAddressLine1", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "ShipCity", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "ShipState", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "ShipCountry", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "ShipPostalCode", c => c.String(maxLength: 20, unicode: false));
            AlterColumn("dbo.AccountingSalesInvoice", "Orderno", c => c.Int());
            AlterColumn("dbo.AccountingSalesInvoice", "OrderDate", c => c.DateTime(storeType: "date"));
            AlterColumn("dbo.AccountingSalesInvoice", "InvoicePono", c => c.Int());
            AlterColumn("dbo.AccountingSalesInvoice", "BillAddressLine1", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingSalesInvoice", "ShipAddressLine1", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingSalesInvoice", "Amount", c => c.Decimal(storeType: "money"));
            AlterColumn("dbo.AccountingSalesInvoice", "Terms&Condition", c => c.String(maxLength: 200, unicode: false));
            AlterColumn("dbo.AccountingProducts", "ProductCode", c => c.Int());
            AlterColumn("dbo.AccountingProducts", "Name", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingProducts", "Quantity", c => c.Int());
            AlterColumn("dbo.AccountingProducts", "Price", c => c.Decimal(storeType: "money"));
            AlterColumn("dbo.AccountingProducts", "Discount", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.AccountingPurchaseInvoice", "Invoiceno", c => c.Int());
            AlterColumn("dbo.AccountingPurchaseInvoice", "InvoiceDate", c => c.DateTime(storeType: "date"));
            AlterColumn("dbo.AccountingPurchaseInvoice", "InvoicePono", c => c.Int());
            AlterColumn("dbo.AccountingPurchaseInvoice", "BillAddressLine1", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingPurchaseInvoice", "ShipAddressLine1", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingPurchaseInvoice", "Amount", c => c.Decimal(storeType: "money"));
            AlterColumn("dbo.AccountingPurchaseInvoice", "Terms&Condition", c => c.String(maxLength: 200, unicode: false));
            AlterColumn("dbo.AccountingSupplier", "Name", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingSupplier", "Telephoneno", c => c.String(maxLength: 15, unicode: false));
            AlterColumn("dbo.AccountingSupplier", "Email", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingSupplier", "ContactPerson", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingSupplier", "Remarks", c => c.String(maxLength: 200, unicode: false));
            AlterColumn("dbo.AccountingSupplier", "BillAddressLine1", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingSupplier", "BillCity", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingSupplier", "BillState", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingSupplier", "BillCountry", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingSupplier", "BillPostalCode", c => c.String(maxLength: 20, unicode: false));
            AlterColumn("dbo.AccountingSupplier", "ShipAddressLine1", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingSupplier", "ShipCity", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingSupplier", "ShipState", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingSupplier", "ShipCountry", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingSupplier", "ShipPostalCode", c => c.String(maxLength: 20, unicode: false));
            AlterColumn("dbo.AccountingPurchaseOrder", "Orderno", c => c.Int());
            AlterColumn("dbo.AccountingPurchaseOrder", "OrderDate", c => c.DateTime(storeType: "date"));
            AlterColumn("dbo.AccountingPurchaseOrder", "DeliveryDate", c => c.DateTime(storeType: "date"));
            AlterColumn("dbo.AccountingPurchaseOrder", "BillAddressLine1", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingPurchaseOrder", "ShipAddressLine1", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingPurchaseOrder", "Amount", c => c.Decimal(storeType: "money"));
            AlterColumn("dbo.AccountingPurchaseOrder", "Terms&Condition", c => c.String(maxLength: 200, unicode: false));
            AlterColumn("dbo.AccountingSalesOrder", "Orderno", c => c.Int());
            AlterColumn("dbo.AccountingSalesOrder", "OrderDate", c => c.DateTime(storeType: "date"));
            AlterColumn("dbo.AccountingSalesOrder", "DeliveryDate", c => c.DateTime(storeType: "date"));
            AlterColumn("dbo.AccountingSalesOrder", "BillAddressLine1", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingSalesOrder", "ShipAddressLine1", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingSalesOrder", "Amount", c => c.Decimal(storeType: "money"));
            AlterColumn("dbo.AccountingSalesOrder", "Terms&Condition", c => c.String(maxLength: 200, unicode: false));
            AlterColumn("dbo.AccountingOptions", "DateFormat", c => c.String(maxLength: 10, unicode: false));
            AlterColumn("dbo.AccountingOptions", "CommaFormat", c => c.String(maxLength: 20, unicode: false));
            AlterColumn("dbo.AccountingOptions", "DecimalFormat", c => c.String(maxLength: 10, unicode: false));
            AlterColumn("dbo.AccountingOptions", "CurrencyType", c => c.String(maxLength: 5, unicode: false));
            AlterColumn("dbo.AccountingOptions", "DefaultBankAccount", c => c.String(maxLength: 20, unicode: false));
            AlterColumn("dbo.AccountingOptions", "Id", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AccountingOptions", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.AccountingOptions", "DefaultBankAccount", c => c.String(nullable: false, maxLength: 20, unicode: false));
            AlterColumn("dbo.AccountingOptions", "CurrencyType", c => c.String(nullable: false, maxLength: 5, unicode: false));
            AlterColumn("dbo.AccountingOptions", "DecimalFormat", c => c.String(nullable: false, maxLength: 10, unicode: false));
            AlterColumn("dbo.AccountingOptions", "CommaFormat", c => c.String(nullable: false, maxLength: 20, unicode: false));
            AlterColumn("dbo.AccountingOptions", "DateFormat", c => c.String(nullable: false, maxLength: 10, unicode: false));
            AlterColumn("dbo.AccountingSalesOrder", "Terms&Condition", c => c.String(nullable: false, maxLength: 200, unicode: false));
            AlterColumn("dbo.AccountingSalesOrder", "Amount", c => c.Decimal(nullable: false, storeType: "money"));
            AlterColumn("dbo.AccountingSalesOrder", "ShipAddressLine1", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingSalesOrder", "BillAddressLine1", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingSalesOrder", "DeliveryDate", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.AccountingSalesOrder", "OrderDate", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.AccountingSalesOrder", "Orderno", c => c.Int(nullable: false));
            AlterColumn("dbo.AccountingPurchaseOrder", "Terms&Condition", c => c.String(nullable: false, maxLength: 200, unicode: false));
            AlterColumn("dbo.AccountingPurchaseOrder", "Amount", c => c.Decimal(nullable: false, storeType: "money"));
            AlterColumn("dbo.AccountingPurchaseOrder", "ShipAddressLine1", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingPurchaseOrder", "BillAddressLine1", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingPurchaseOrder", "DeliveryDate", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.AccountingPurchaseOrder", "OrderDate", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.AccountingPurchaseOrder", "Orderno", c => c.Int(nullable: false));
            AlterColumn("dbo.AccountingSupplier", "ShipPostalCode", c => c.String(nullable: false, maxLength: 20, unicode: false));
            AlterColumn("dbo.AccountingSupplier", "ShipCountry", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingSupplier", "ShipState", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingSupplier", "ShipCity", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingSupplier", "ShipAddressLine1", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingSupplier", "BillPostalCode", c => c.String(nullable: false, maxLength: 20, unicode: false));
            AlterColumn("dbo.AccountingSupplier", "BillCountry", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingSupplier", "BillState", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingSupplier", "BillCity", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingSupplier", "BillAddressLine1", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingSupplier", "Remarks", c => c.String(nullable: false, maxLength: 200, unicode: false));
            AlterColumn("dbo.AccountingSupplier", "ContactPerson", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingSupplier", "Email", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingSupplier", "Telephoneno", c => c.String(nullable: false, maxLength: 15, unicode: false));
            AlterColumn("dbo.AccountingSupplier", "Name", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingPurchaseInvoice", "Terms&Condition", c => c.String(nullable: false, maxLength: 200, unicode: false));
            AlterColumn("dbo.AccountingPurchaseInvoice", "Amount", c => c.Decimal(nullable: false, storeType: "money"));
            AlterColumn("dbo.AccountingPurchaseInvoice", "ShipAddressLine1", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingPurchaseInvoice", "BillAddressLine1", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingPurchaseInvoice", "InvoicePono", c => c.Int(nullable: false));
            AlterColumn("dbo.AccountingPurchaseInvoice", "InvoiceDate", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.AccountingPurchaseInvoice", "Invoiceno", c => c.Int(nullable: false));
            AlterColumn("dbo.AccountingProducts", "Discount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.AccountingProducts", "Price", c => c.Decimal(nullable: false, storeType: "money"));
            AlterColumn("dbo.AccountingProducts", "Quantity", c => c.Int(nullable: false));
            AlterColumn("dbo.AccountingProducts", "Name", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingProducts", "ProductCode", c => c.Int(nullable: false));
            AlterColumn("dbo.AccountingSalesInvoice", "Terms&Condition", c => c.String(nullable: false, maxLength: 200, unicode: false));
            AlterColumn("dbo.AccountingSalesInvoice", "Amount", c => c.Decimal(nullable: false, storeType: "money"));
            AlterColumn("dbo.AccountingSalesInvoice", "ShipAddressLine1", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingSalesInvoice", "BillAddressLine1", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingSalesInvoice", "InvoicePono", c => c.Int(nullable: false));
            AlterColumn("dbo.AccountingSalesInvoice", "OrderDate", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.AccountingSalesInvoice", "Orderno", c => c.Int(nullable: false));
            AlterColumn("dbo.AccountingCustomer", "ShipPostalCode", c => c.String(nullable: false, maxLength: 20, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "ShipCountry", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "ShipState", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "ShipCity", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "ShipAddressLine1", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "BillPostalCode", c => c.String(nullable: false, maxLength: 20, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "BillCountry", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "BillState", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "BillCity", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "BillAddressLine1", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "Remarks", c => c.String(nullable: false, maxLength: 200, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "ContactPerson", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "Email", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "Telephoneno", c => c.String(nullable: false, maxLength: 15, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "SalesMan", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "CustomerType", c => c.String(nullable: false, maxLength: 20, unicode: false));
            AlterColumn("dbo.AccountingCustomer", "Name", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingCompanyDetails", "ShipPostalCode", c => c.String(nullable: false, maxLength: 10, unicode: false));
            AlterColumn("dbo.AccountingCompanyDetails", "ShipCountry", c => c.String(nullable: false, maxLength: 20, unicode: false));
            AlterColumn("dbo.AccountingCompanyDetails", "ShipState", c => c.String(nullable: false, maxLength: 20, unicode: false));
            AlterColumn("dbo.AccountingCompanyDetails", "ShipCity", c => c.String(nullable: false, maxLength: 20, unicode: false));
            AlterColumn("dbo.AccountingCompanyDetails", "ShipAddressLine2", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingCompanyDetails", "ShipAddressLine1", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingCompanyDetails", "BillPostalCode", c => c.String(nullable: false, maxLength: 10, unicode: false));
            AlterColumn("dbo.AccountingCompanyDetails", "BillCountry", c => c.String(nullable: false, maxLength: 20, unicode: false));
            AlterColumn("dbo.AccountingCompanyDetails", "BillState", c => c.String(nullable: false, maxLength: 20, unicode: false));
            AlterColumn("dbo.AccountingCompanyDetails", "BillCity", c => c.String(nullable: false, maxLength: 20, unicode: false));
            AlterColumn("dbo.AccountingCompanyDetails", "BillAddressLine1", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.AccountingCompanyDetails", "Email", c => c.String(nullable: false, maxLength: 30, unicode: false));
            AlterColumn("dbo.AccountingCompanyDetails", "Telephoneno", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.AccountingCompanyDetails", "Registrationno", c => c.Int(nullable: false));
            AlterColumn("dbo.AccountingCompanyDetails", "CompanyName", c => c.String(nullable: false, maxLength: 200, unicode: false));
            DropColumn("dbo.AccountingOptions", "UpdatedBy");
            DropColumn("dbo.AccountingOptions", "UpdatedDate");
            DropColumn("dbo.AccountingOptions", "CreatedBy");
            DropColumn("dbo.AccountingOptions", "CreatedDate");
            DropTable("dbo.AccountingLogin");
            RenameColumn(table: "dbo.AccountingSalesOrder", name: "SupplierName", newName: "CustomerName");
        }
    }
}
