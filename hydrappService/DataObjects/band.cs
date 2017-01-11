using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace hydrappService.DataObjects
{
    public class Band: EntityData
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BandId { get; set; }
        public int UserId { get; set; }
        public string BandName { get; set; }
    }
}