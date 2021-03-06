﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Garage2._6.Models
{
    public class ReceiptViewModel
    {
        public ReceiptViewModel(int id, string regnr, VehicleType vehicleType, DateTime checkIn, DateTime nowTime)
        {
            Id = id;
            RegNr = regnr;
            VehicleType = vehicleType;
            CheckIn = checkIn;
            NowTime = nowTime;
            TimeSpan ts = NowTime - CheckIn;
            TotalTime = $"{Math.Floor(ts.TotalDays)} days, {ts.Hours} hours and {ts.Minutes} minutes.";
            Price = (ts.TotalMinutes + 1) * 2;

        }



        public int Id { get; set; }
        public string RegNr { get; private set; }
        public virtual VehicleType VehicleType { get; set; }
        [Display(Name = "Time Parked")]
        public DateTime CheckIn { get; private set; }
        [Display]
        public DateTime NowTime { get; private set; }
        public string TotalTime { get; private set; }
        public double Price { get; private set; }
    }
}