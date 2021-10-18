namespace WebAppAspNetMvcHtml.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeBookAddIsArchive : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "IsArchive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "IsArchive");
        }
    }
}
