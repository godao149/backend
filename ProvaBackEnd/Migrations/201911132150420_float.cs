namespace ProvaBackEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _float : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Valors", "ValorMin", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Valors", "ValorMin", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
