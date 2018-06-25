using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Garage2._6.Models
{
    public class ReceiptViewModel
    {

        public ReceiptViewModel(int id,string regnr, DateTime checkIn, DateTime checkOut)
        {

            RegNr = regnr;        
            CheckIn = checkIn.Date;
            CheckOut = checkOut.Date;
            var total = CheckOut - CheckIn;

          

            Price = (total.TotalMinutes + 1) * 2;

        }



        public int Id { get; set; }
        public string RegNr { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public int NumberofEngines { get; set; }
        public VehicleType VehicleType { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public DateTime TotalTime { get; set; }
        public double Price { get; set; }

    }
}