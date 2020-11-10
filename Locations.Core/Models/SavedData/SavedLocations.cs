using System;
using System.Collections.Generic;
using System.Text;

namespace Locations.Core.Models.SavedData
{
    public class SavedLocations
    {
        public string Id{ get; set; }
        public string Name { get; set; }
        public string  Address { get; set; }
        public string CrossStreet { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Image { get; set; }
    }
}
