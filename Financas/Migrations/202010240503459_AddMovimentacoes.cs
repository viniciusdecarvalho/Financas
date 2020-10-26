namespace Financas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovimentacoes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movimentacaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        Tipo = c.Int(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movimentacaos", "UsuarioId", "dbo.Usuarios");
            DropIndex("dbo.Movimentacaos", new[] { "UsuarioId" });
            DropTable("dbo.Movimentacaos");
        }
    }
}
