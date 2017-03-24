using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace hydrappService.DataObjects
{
    public class Activity: EntityData
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ActivityId { get; set; }
        public int GroupId { get; set; }
        public int ActivityLvl { get; set; }
        public DateTime ActivityTime { get; set; }
        public int Done { get; set; }
    }
}