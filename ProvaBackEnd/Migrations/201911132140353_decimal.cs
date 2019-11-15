namespace ProvaBackEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _decimal : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ligacaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tempo = c.DateTime(nullable: false),
                        Plano = c.Int(nullable: false),
                        ValorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Valors", t => t.ValorId, cascadeDelete: true)
                .Index(t => t.ValorId);
            
            CreateTable(
                "dbo.Valors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Origem = c.String(),
                        Destino = c.String(),
                        ValorMin = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ligacaos", "ValorId", "dbo.Valors");
            DropIndex("dbo.Ligacaos", new[] { "ValorId" });
            DropTable("dbo.Valors");
            DropTable("dbo.Ligacaos");
        }
    }
}
