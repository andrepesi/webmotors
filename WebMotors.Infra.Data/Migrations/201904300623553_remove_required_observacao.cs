namespace WebMotors.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remove_required_observacao : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Anuncios", "observacao", c => c.String(unicode: false, storeType: "text"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Anuncios", "observacao", c => c.String(nullable: false, unicode: false, storeType: "text"));
        }
    }
}
