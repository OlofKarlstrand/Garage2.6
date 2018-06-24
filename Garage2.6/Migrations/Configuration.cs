namespace Garage2._6.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Garage2._6.DataAccessLayer.GarageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Garage2._6.DataAccessLayer.GarageContext";
        }

        protected override void Seed(Garage2._6.DataAccessLayer.GarageContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.ParkedVehicles.AddOrUpdate(
                v => new { v.RegNr },

                new Models.ParkedVehicle
                {
                    RegNr = "STA123",
                    Description = "Thunderbird 5",
                    Color = "Purple",
                    NumberofEngines = 20,
                    CheckIn = DateTime.Now,
                    Type = "Space Station"

                },
                new Models.ParkedVehicle
                {
                    RegNr = "LKJ345",
                    Description = "Thunderbird 4",
                    Color = "Yellow",
                    NumberofEngines = 4,
                    CheckIn = DateTime.Now,
                    Type = "Submarine"
                },
                new Models.ParkedVehicle
                {
                    RegNr = "BNM678",
                    Description = "Thunderbird 3",
                    Color = "Green",
                    NumberofEngines = 12,
                    CheckIn = DateTime.Now,
                    Type = "Spaceship"
                },

                new Models.ParkedVehicle
                {
                    RegNr = "TYU935",
                    Description = "Thunderbird 2",
                    Color = "Blue",
                    NumberofEngines = 4,
                    CheckIn = DateTime.Now,
                    Type = "AircraftTransporter"
                },
                new Models.ParkedVehicle
                {
                    RegNr = "FYI666",
                    Description = "Thunderbird 1",
                    Color = "Black",
                    NumberofEngines = 4,
                    CheckIn = DateTime.Now,
                    Type = "Rocketplane"
                }
                );
                context.SaveChanges();
        }
    }
}
