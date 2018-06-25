using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Garage2._6.Models
{
    public class CheckOutVehicle
    {
        
        public CheckOutVehicle(int id, string regnr, DateTime checkIn, DateTime nowTime)
        {
            Id = id;
            Regnr = regnr;
            CheckIn = checkIn;
            NowTime = nowTime;
        }

        public int Id { get; set; }
        public string Regnr { get; set; }

        [Display(Name = "Arrival time")]
        public DateTime CheckIn { get; set; }

        [Display(Name = "Check out time")]
        public DateTime NowTime { get; set; }
    }
}