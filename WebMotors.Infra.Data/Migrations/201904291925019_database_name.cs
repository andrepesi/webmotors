namespace WebMotors.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class database_name : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Anuncios",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        marca = c.String(nullable: false, maxLength: 45),
                        modelo = c.String(nullable: false, maxLength: 45),
                        versao = c.String(nullable: false, maxLength: 45),
                        ano = c.Int(nullable: false),
                        quilometragem = c.Int(nullable: false),
                        observacao = c.String(nullable: false, unicode: false, storeType: "text"),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Anuncios");
        }
    }
}
