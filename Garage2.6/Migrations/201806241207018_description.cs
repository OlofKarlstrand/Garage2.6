namespace Garage2._6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class description : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ParkedVehicles", "Description", c => c.String(nullable: false));
            DropColumn("dbo.ParkedVehicles", "Kind");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ParkedVehicles", "Kind", c => c.String(nullable: false));
            DropColumn("dbo.ParkedVehicles", "Description");
        }
    }
}
