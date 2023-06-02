namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieAndGenre2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Family')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Fantasy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Horror')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (7, 'Thriller')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (8, 'Science Fiction')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (9, 'Drama')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (10, 'Adventure')");
        }
        
        public override void Down()
        {
        }
    }
}
