namespace Garage2._6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class park : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ParkedVehicles", "Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ParkedVehicles", "Description", c => c.String(nullable: false));
        }
    }
}
