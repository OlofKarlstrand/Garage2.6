using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage2._6.Models
{
    public class VehicleType
    {
        public int VehicleTypeId { get; set; }

        public string TypeName { get; set; }

        public virtual ICollection<ParkedVehicle> ParkedVehicles { get; set; }

    }
}