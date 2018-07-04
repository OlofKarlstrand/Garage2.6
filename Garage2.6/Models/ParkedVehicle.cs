using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Garage2._6.Models
{
    public class ParkedVehicle
    {
        public int Id { get; set; }

        [Required]
        [DisplayName ("Registration Number")]
        public string RegNr { get; set; }
        
        public string Description { get; set; }

        public string Color { get; set; }
        [DisplayName ("Number of Engines")]
        public int NumberofEngines { get; set; }

       

        [UIHint("DateFormat")]
        [DisplayName ("Time Checked In")]
        public DateTime CheckIn { get; set; }



        public int VehicleTypeId { get; set; }
        [DisplayName("Type of Vehicle")]
        public virtual VehicleType VehicleType { get; set; }
        
        

        public virtual Member Members { get; set; } 
        public int MemberId { get; internal set; }

       
    }

}