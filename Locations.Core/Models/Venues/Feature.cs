using System;
using System.Collections.Generic;
using System.Text;

namespace Locations.Core.Models.Venues
{
    public class Feature
    {
        public string cc { get; set; }
        public string name { get; set; }
        public string displayName { get; set; }
        public string matchedName { get; set; }
        public string highlightedName { get; set; }
        public int woeType { get; set; }
        public string slug { get; set; }
        public string id { get; set; }
        public string longId { get; set; }
        public Geometry geometry { get; set; }
    }
}
