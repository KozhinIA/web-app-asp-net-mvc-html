namespace WebAppAspNetMvcHtml.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeBookAddAnnotation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Annotation", c => c.String(nullable: false));
            DropColumn("dbo.Books", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Description", c => c.String(nullable: false));
            DropColumn("dbo.Books", "Annotation");
        }
    }
}
