namespace ProvaBackEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _double : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Valors", "ValorMin", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Valors", "ValorMin", c => c.String());
        }
    }
}
