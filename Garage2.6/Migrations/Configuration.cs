namespace Garage2._6.Migrations
{
    using Garage2._6.Models;
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

            var members = new[]{
                new Member() { FirstName = "Scott", LastName = "Tracy", Email = "Scott@IR.com"},
                new Member () {FirstName ="John", LastName ="Tracy", Email ="John@IR.com"},
                new Member () {FirstName ="Virgil", LastName ="Tracy", Email ="Virgil@IR.com"},
                new Member () {FirstName ="Gordon", LastName ="Tracy", Email = "Gordon@IR.com"},
                new Member () {FirstName ="Alan", LastName ="Tracy", Email="Tracy@IR.com"},
                

        };

            context.Members.AddOrUpdate(m => m.FirstName, members);
            
            context.SaveChanges();

            var types = new[] {
                new VehicleType() { TypeName = "Spacestation" },
                new VehicleType() { TypeName = "Spaceship" },
                new VehicleType() { TypeName = "Submarine"},
                new VehicleType() { TypeName ="AircraftTransporter"},
                new VehicleType() { TypeName ="Rocketplane"}
                };



            context.VehicleType.AddOrUpdate(t => t.TypeName, types[0], types[1], types[2], types[3], types[4]);

            context.SaveChanges();

            var vehicle = new[]
            {
                new ParkedVehicle (){

                    RegNr = "FYI666",
                    Description = "Thunderbird 1",
                    Color = "Silver",
                    NumberofEngines = 4,
                    CheckIn = DateTime.Now,
                    MemberId = members[0].MemberId,
                    VehicleTypeId = types[4].Id,


                },


                new ParkedVehicle()
                {
                    RegNr = "TYU935",
                    Description = "Thunderbird 2",
                    Color = "Blue",
                    NumberofEngines = 8,
                    CheckIn = DateTime.Now,
                    MemberId= members[2].MemberId,
                    VehicleTypeId = types[3].Id,

                },

                new ParkedVehicle()
                {
                    RegNr = "BNM678",
                    Description = "Thunderbird 3",
                    Color = "Green",
                    NumberofEngines = 12,
                    CheckIn = DateTime.Now,
                    MemberId = members[4].MemberId,
                    VehicleTypeId = types[1].Id,
                },
                new ParkedVehicle()
                {
                    RegNr = "LKJ345",
                    Description = "Thunderbird 4",
                    Color = "Yellow",
                    NumberofEngines = 8,
                    CheckIn = DateTime.Now,
                    MemberId = members[3].MemberId,
                    VehicleTypeId = types[2].Id,

                },
                new ParkedVehicle ()
                {
                    RegNr = "STA123",
                    Description = "Thunderbird 5",
                    Color = "Purple",
                    NumberofEngines = 20,
                    CheckIn = DateTime.Now,
                    MemberId = members[1].MemberId,
                    VehicleTypeId = types[0].Id

                }
            };

            context.ParkedVehicles.AddOrUpdate(t => t.RegNr, vehicle);
            context.SaveChanges();

        }
    }
}
