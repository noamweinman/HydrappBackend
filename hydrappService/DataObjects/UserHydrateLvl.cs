using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace hydrappService.DataObjects
{
    public class UserHydrateLvl: EntityData
    {
        public int UserId { get; set; }
        public int Lvl1Count { get; set; }
        public long Lvl1Avg { get; set; }
        public int Lvl2Count { get; set; }
        public long Lvl2Avg { get; set; }
        public int Lvl3Count { get; set; }
        public long Lvl3Avg { get; set; }
    }
}