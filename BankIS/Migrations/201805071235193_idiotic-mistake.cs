namespace BankIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class idioticmistake : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE ServiceTypes SET Name='Fixed Deposit' WHERE Name='Depozit'");
            Sql("Delete ServiceTypes WHERE Name=''");
        }
        
        public override void Down()
        {
        }
    }
}
