using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace hydrappService.DataObjects
{
    public class Group: EntityData
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string Password { get; set; }
    }
}