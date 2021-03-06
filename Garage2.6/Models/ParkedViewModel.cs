﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Garage2._6.Models
{
    public class ParkedViewModel
    {

       // public int Id { get; set; }
        public string RegNr { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public int NumberofEngines { get; set; }
        [Required]
        [DisplayName("Owner")]
        public int MemberId { get; set; }
        //public string TypeName { get; set; }
        //public VehicleType TypeName { get; set; }
        [DisplayName("Type of Vehicle")]
        public VehicleType VehicleType { get; set; }
        public int VehicleTypeId { get; set; }
       
        public IEnumerable<Member> ListMembers { get; set; }
        public IEnumerable<VehicleType> Types { get; set; }

        //[UIHint("DateFormat")]
        //[DisplayName("Time Checked In")]
        //public DateTime CheckIn { get; set; }
    }
}