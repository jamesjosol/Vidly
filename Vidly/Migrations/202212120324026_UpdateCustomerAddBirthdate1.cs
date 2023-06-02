namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomerAddBirthdate1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '2000-07-03' WHERE id = 1003");
            Sql("UPDATE Customers SET BirthDate = '1995-10-25' WHERE id = 5");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsLetter, MembershipTypeId, BirthDate) VALUES ('John Doe', 1, 2, '1989-09-06')");
        }
        
        public override void Down()
        {
        }
    }
}
