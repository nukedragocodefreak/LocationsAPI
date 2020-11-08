using System;
using System.Collections.Generic;
using System.Text;

namespace Locations.Core.Models.Venues
{
    public class Geocode
    {
        public string what { get; set; }
        public string where { get; set; }
        public Feature feature { get; set; }
        public object[] parents { get; set; }
    }
}
