using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage2._6.Models
{
    public class Member
    {
        public int MemberId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public VehicleType VehicleType { get; set; }

        public virtual ICollection<ParkedVehicle> ParkedVehicles { get; set; }
    }
}