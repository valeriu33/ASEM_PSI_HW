namespace BankIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correct_mistakes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "FirstName", c => c.String());
            AddColumn("dbo.Clients", "LastName", c => c.String());
            AddColumn("dbo.Clients", "BirthDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Clients", "Name");
            DropColumn("dbo.Clients", "Prenume");
            DropColumn("dbo.Clients", "BithDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "BithDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Clients", "Prenume", c => c.String());
            AddColumn("dbo.Clients", "Name", c => c.String());
            DropColumn("dbo.Clients", "BirthDate");
            DropColumn("dbo.Clients", "LastName");
            DropColumn("dbo.Clients", "FirstName");
        }
    }
}
