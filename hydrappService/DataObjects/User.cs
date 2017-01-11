using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace hydrappService.DataObjects
{
    public class User: EntityData
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public double height { get; set; }
        public double weight { get; set; }
    }
}