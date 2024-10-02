namespace Bookstore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookIsbn = c.String(nullable: false, maxLength: 100),
                        BookId = c.Int(nullable: false),
                        BookTitle = c.String(maxLength: 100),
                        BookAuthor = c.String(maxLength: 100),
                        BookYear = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BookEditora = c.String(maxLength: 100),
                        BookGenre = c.String(maxLength: 100),
                        BookAmount = c.Int(nullable: false),
                        BookPrice = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.BookIsbn);
            
            CreateTable(
                "dbo.BooksStokes",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        BookIsbn = c.String(maxLength: 100),
                        BookTitle = c.String(maxLength: 100),
                        BookAuthor = c.String(maxLength: 100),
                        BookYear = c.Int(nullable: false),
                        BookEditora = c.String(maxLength: 100),
                        BookGenre = c.String(maxLength: 100),
                        BookAmount = c.Int(nullable: false),
                        BookPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.BookId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 100),
                        UserName = c.String(maxLength: 100),
                        UserNick = c.String(maxLength: 100),
                        UserPassword = c.String(maxLength: 100),
                        UserFunction = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.BooksStokes");
            DropTable("dbo.Books");
        }
    }
}
