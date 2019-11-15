namespace ProvaBackEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class decimal1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Valors", "ValorMin", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Valors", "ValorMin", c => c.Decimal(precision: 18, scale: 2));
        }
    }
}
