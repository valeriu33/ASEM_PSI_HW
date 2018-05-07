namespace BankIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedclientIdandserviceTypeId : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Services", name: "Client_ID", newName: "ClientId");
            RenameColumn(table: "dbo.Services", name: "ServiceType_Id", newName: "ServiceTypeId");
            RenameIndex(table: "dbo.Services", name: "IX_Client_ID", newName: "IX_ClientId");
            RenameIndex(table: "dbo.Services", name: "IX_ServiceType_Id", newName: "IX_ServiceTypeId");

            Sql("INSERT INTO ServiceTypes VALUES('Current Deposit')");
            Sql("INSERT INTO ServiceTypes VALUES('Mortgage Credit')");

        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Services", name: "IX_ServiceTypeId", newName: "IX_ServiceType_Id");
            RenameIndex(table: "dbo.Services", name: "IX_ClientId", newName: "IX_Client_ID");
            RenameColumn(table: "dbo.Services", name: "ServiceTypeId", newName: "ServiceType_Id");
            RenameColumn(table: "dbo.Services", name: "ClientId", newName: "Client_ID");
        }
    }
}
