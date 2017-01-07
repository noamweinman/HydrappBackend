using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hydrappService.DataObjects
{
    public class User: EntityData
    {
        public String userName { get; set; }
        public String password { get; set; }
        public String email { get; set; }
        public double bmi { get; set; }
    }
}