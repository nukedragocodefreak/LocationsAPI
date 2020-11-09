using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Locations.Core.Models.Parameters
{
    public class VenueParameters
    {
        public string Near { get; set; }
        public string Intent { get; set; }
        // [StringLength(100000, MinimumLength = 0, ErrorMessage = "Radius is between 0 and 100000 range")]
        [Range(10, 50, ErrorMessage = "The Radius you can view  per location is between 0 and 100000")]
        public int Radius { get; set; }
        // [StringLength(50, MinimumLength = 10, ErrorMessage = "Limit is between 10 and 50 range")]
        [Range(10, 50, ErrorMessage = "The range for the pictures you can view per location is between 10 and 50")]
        public int Limit { get; set; }
    }
}
