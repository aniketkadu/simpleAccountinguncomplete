namespace SimpleAccounting.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class praneetthakur_for_editing_Auditable_entity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AccountingOptions", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AccountingOptions", "CreatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.AccountingOptions", "UpdatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AccountingOptions", "UpdatedBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.AccountingOptions", "Id", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AccountingOptions", "Id", c => c.Int(nullable: false));
            DropColumn("dbo.AccountingOptions", "UpdatedBy");
            DropColumn("dbo.AccountingOptions", "UpdatedDate");
            DropColumn("dbo.AccountingOptions", "CreatedBy");
            DropColumn("dbo.AccountingOptions", "CreatedDate");
        }
    }
}
