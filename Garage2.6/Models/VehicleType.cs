using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage2._6.Models
{
    public class VehicleType
    {
        public int Id { get; set; }

        public string TypeName { get; set; }

        public virtual IEnumerable<ParkedVehicle> ParkedVehicles { get; set; }

        public virtual IEnumerable<Member> Members { get; set; }
    }
}