namespace SimpleAccounting.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class praneetthakur_2_for_logo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AccountingCompanyDetails", "LogoImage", c => c.Binary(storeType: "image"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AccountingCompanyDetails", "LogoImage", c => c.Binary(nullable: false, storeType: "image"));
        }
    }
}
