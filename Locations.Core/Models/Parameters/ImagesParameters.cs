using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Locations.Core.Models.Parameters
{
    public class ImagesParameters
    {
        public string VenueID { get; set; }
        public string Group { get; set; }

        [StringLength(50, MinimumLength = 10, ErrorMessage = "Limit is between 10 and 50 range")]
        public string Limit { get; set; }
    }
}
