namespace TurkTicaretCRM.TT.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustmerDebitUpdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerDebits",
                c => new
                    {
                        CustomerDebitID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        DebitID = c.Int(nullable: false),
                        DebitTotal = c.Int(nullable: false),
                        CustomerDebitStatus = c.Boolean(nullable: false),
                        RegistrationDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerDebitID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Debits", t => t.DebitID, cascadeDelete: true)
                .Index(t => t.CustomerID)
                .Index(t => t.DebitID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerDebits", "DebitID", "dbo.Debits");
            DropForeignKey("dbo.CustomerDebits", "CustomerID", "dbo.Customers");
            DropIndex("dbo.CustomerDebits", new[] { "DebitID" });
            DropIndex("dbo.CustomerDebits", new[] { "CustomerID" });
            DropTable("dbo.CustomerDebits");
        }
    }
}
