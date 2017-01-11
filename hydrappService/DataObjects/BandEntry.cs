using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace hydrappService.DataObjects
{
    public class BandEntry: EntityData
    {
        public DateTime TimeStamp { get; set; }
        public int GroupId { get; set; }
        public int UserId { get; set; }
        public int BandId { get; set; }
        public int GSR { get; set; }
        public double SkinTemp { get; set; }
        public int Light { get; set; }
        public int HeartRate { get; set; }
        public int UV { get; set; }
        public int Calories { get; set; }
        public int Steps { get; set; }
        public double FluidLoss { get; set; }
        public bool IsDehydrated { get; set; }

    }
}