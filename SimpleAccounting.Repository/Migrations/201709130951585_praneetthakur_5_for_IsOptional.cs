namespace SimpleAccounting.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class praneetthakur_5_for_IsOptional : DbMigration
    {
        public override void Up()
        {
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
        }
        
        public override void Down()
        {
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
        }
    }
}
