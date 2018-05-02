namespace BankIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_service_samples : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO ServiceTypes VALUES('Credit')");
            Sql("INSERT INTO ServiceTypes VALUES('Depozit')");
        }
        
        public override void Down()
        {
        }
    }
}
