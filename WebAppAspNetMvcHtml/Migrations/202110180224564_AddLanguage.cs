namespace WebAppAspNetMvcHtml.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLanguage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LanguageBooks",
                c => new
                    {
                        Language_Id = c.Int(nullable: false),
                        Book_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Language_Id, t.Book_Id })
                .ForeignKey("dbo.Languages", t => t.Language_Id, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Book_Id, cascadeDelete: true)
                .Index(t => t.Language_Id)
                .Index(t => t.Book_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LanguageBooks", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.LanguageBooks", "Language_Id", "dbo.Languages");
            DropIndex("dbo.LanguageBooks", new[] { "Book_Id" });
            DropIndex("dbo.LanguageBooks", new[] { "Language_Id" });
            DropTable("dbo.LanguageBooks");
            DropTable("dbo.Languages");
        }
    }
}
