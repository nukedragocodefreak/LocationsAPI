using System;
using System.Collections.Generic;
using System.Text;

namespace Locations.Core.Models.Image
{
    public class Venue
    {
        public string id { get; set; }
        public string name { get; set; }
        public Location location { get; set; }
        public Category[] categories { get; set; }
        public Venuepage venuePage { get; set; }
    }
}
