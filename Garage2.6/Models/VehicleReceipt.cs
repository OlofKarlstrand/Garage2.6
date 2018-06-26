﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Garage2._6.Models
{
    public class VehicleReceipt
    {
        public VehicleReceipt(int id, string regnr, DateTime checkIn, DateTime nowTime)
        {
            Id = id;
            RegNr = regnr;
            //VehicleType = vehicleType;
            CheckIn = checkIn;
            NowTime = nowTime;
            TimeSpan ts = NowTime - CheckIn;
            TotalTime = $"{Math.Floor(ts.TotalDays)} days, {ts.Hours} hours and {ts.Minutes} minutes.";
            Price = (ts.TotalMinutes + 1) * 2;

        }


        public int Id { get; private set; }
        public string RegNr { get; private set; }
        public VehicleType VehicleType { get; private set; }
        [Display(Name = "Time Parked")]
        public DateTime CheckIn { get; private set; }
        [Display]
        public DateTime NowTime { get; private set; }
        public string TotalTime { get; private set; }
        public double Price { get; private set; }
    }
}
   