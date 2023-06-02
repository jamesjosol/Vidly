namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovie1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Hangover', 1, GETDATE(), '2009-08-12', 0)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Die Hard', 2, GETDATE(), '1988-09-27', 0)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('The Terminator', 2, GETDATE(), '1984-10-26', 0)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Toy Story', 3, GETDATE(), '1996-05-01', 0)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Titanic', 4, GETDATE(), '1998-02-04', 0)");
        }
        
        public override void Down()
        {
        }
    }
}
