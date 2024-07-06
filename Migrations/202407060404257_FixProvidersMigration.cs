namespace CuentasXPagar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixProvidersMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProvidersModels", "PersonType", c => c.String());
            AddColumn("dbo.ProvidersModels", "State", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProvidersModels", "State");
            DropColumn("dbo.ProvidersModels", "PersonType");
        }
    }
}
