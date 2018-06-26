using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Garage2._6.DataAccessLayer
{
    public class GarageContext : DbContext
    {
        public GarageContext() : base("Thunderbird")
        {

        }

        public DbSet<Garage2._6.Models.ParkedVehicle> ParkedVehicles { get; set; }

        public DbSet<Garage2._6.Models.Member> Members { get; set; }
    }
}