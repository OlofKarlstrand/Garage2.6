namespace Garage2._6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class control : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ParkedVehicles", "Type", c => c.String());
            AddColumn("dbo.ParkedVehicles", "DropType", c => c.Int(nullable: false));
            DropColumn("dbo.ParkedVehicles", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ParkedVehicles", "Description", c => c.String());
            DropColumn("dbo.ParkedVehicles", "DropType");
            DropColumn("dbo.ParkedVehicles", "Type");
        }
    }
}
