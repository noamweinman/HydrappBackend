using Microsoft.Azure.Mobile.Server;
using System;

namespace hydrappService.DataObjects
{
    public class TestItem : EntityData
    {
        public string name { get; set; }

        public DateTime date { get; set; }
    }
}