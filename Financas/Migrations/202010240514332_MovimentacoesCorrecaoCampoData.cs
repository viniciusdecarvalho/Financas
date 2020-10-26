namespace Financas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovimentacoesCorrecaoCampoData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movimentacaos", "Data", c => c.DateTime(nullable: false));
            DropColumn("dbo.Movimentacaos", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movimentacaos", "Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.Movimentacaos", "Data");
        }
    }
}
