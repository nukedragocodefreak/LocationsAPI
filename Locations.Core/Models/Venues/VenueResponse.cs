using System;
using System.Collections.Generic;
using System.Text;

namespace Locations.Core.Models.Venues
{
    public class VenueResponse
    {
        public Venue[] venues { get; set; }
        public Geocode geocode { get; set; }
    }
}
