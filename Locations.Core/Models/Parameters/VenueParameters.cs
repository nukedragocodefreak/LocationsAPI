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
        [StringLength(100000, MinimumLength = 0, ErrorMessage = "Radius is between 0 and 100000 range")]
        public string Radius { get; set; }
        [StringLength(50, MinimumLength = 10, ErrorMessage = "Limit is between 10 and 50 range")]
        public string Limit { get; set; }
    }
}
