namespace CuentasXPagar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAccountingStatements : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountingStatements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        InventoryID = c.Int(nullable: false),
                        Account = c.String(),
                        TypeOfMovement = c.String(),
                        EntryDate = c.DateTime(nullable: false),
                        Ammount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        State = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AccountingStatements");
        }
    }
}
