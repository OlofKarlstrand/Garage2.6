namespace Garage2._6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ParkedVehicles", "Kind", c => c.String(nullable: false));
            AddColumn("dbo.ParkedVehicles", "NumberofEngines", c => c.Int(nullable: false));
            AddColumn("dbo.ParkedVehicles", "Description", c => c.String());
            AlterColumn("dbo.ParkedVehicles", "RegNr", c => c.String(nullable: false));
            DropColumn("dbo.ParkedVehicles", "Brand");
            DropColumn("dbo.ParkedVehicles", "NumberofWheels");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ParkedVehicles", "NumberofWheels", c => c.Int(nullable: false));
            AddColumn("dbo.ParkedVehicles", "Brand", c => c.String());
            AlterColumn("dbo.ParkedVehicles", "RegNr", c => c.String());
            DropColumn("dbo.ParkedVehicles", "Description");
            DropColumn("dbo.ParkedVehicles", "NumberofEngines");
            DropColumn("dbo.ParkedVehicles", "Kind");
        }
    }
}
