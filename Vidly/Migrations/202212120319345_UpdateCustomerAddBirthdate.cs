namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomerAddBirthdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '2000-07-03' WHERE id = 1003");
            Sql("UPDATE Customers SET BirthDate = '1995-10-25' WHERE id = 5");
        }
        
        public override void Down()
        {
        }
    }
}
