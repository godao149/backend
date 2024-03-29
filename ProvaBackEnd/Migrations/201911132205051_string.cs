namespace ProvaBackEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _string : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Valors", "ValorMin", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Valors", "ValorMin", c => c.Single(nullable: false));
        }
    }
}
