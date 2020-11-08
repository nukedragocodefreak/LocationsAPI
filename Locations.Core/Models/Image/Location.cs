using System;
using System.Collections.Generic;
using System.Text;

namespace Locations.Core.Models.Image
{
    public class Location
    {
        public float lat { get; set; }
        public float lng { get; set; }
        public string postalCode { get; set; }
        public string cc { get; set; }
        public string neighborhood { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string[] formattedAddress { get; set; }
    }
}
