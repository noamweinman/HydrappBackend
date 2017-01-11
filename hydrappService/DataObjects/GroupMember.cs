using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace hydrappService.DataObjects
{
    public class GroupMember: EntityData
    {
        public int UserId { get; set; }
        public int GroupId { get; set; }
        public bool Admin { get; set; }
    }
}