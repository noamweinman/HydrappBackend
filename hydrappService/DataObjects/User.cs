using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hydrappService.DataObjects
{
    public class User: EntityData
    {
        public string userName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public double bmi { get; set; }
    }
}