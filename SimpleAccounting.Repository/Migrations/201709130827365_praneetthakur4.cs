namespace SimpleAccounting.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class praneetthakur4 : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AccountingLogin");
        }
    }
}
