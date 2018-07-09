using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Garage2._6.Models
{
    public class ParkedVehicle
    {
        public ParkedVehicle()
        {
               
        }
        
        public int Id { get; set; }

        
        [DisplayName("Registration Number")]
        public string RegNr { get; set; }

        public string Description { get; set; }

        public string Color { get; set; }
        [DisplayName("Number of Engines")]
        public int NumberofEngines { get; set; }
        

        [UIHint("DateFormat")]
        [DisplayName("Time Checked In")]
        [Column(TypeName = "datetime2")]
        public DateTime CheckIn { get; set; }



        [DisplayName("Type of Vehicle")]
        public virtual VehicleType VehicleType { get; set; }

        public int VehicleTypeId { get; set; }
        
        public virtual Member Members { get; set; }
        public int MemberId { get; set; }


        //public virtual IEnumerable<Member> Members { get; set; }
        public IEnumerable<VehicleType> Types { get; set; }

        public IEnumerable<Member> ListMembers { get; set; }
    




    }

}