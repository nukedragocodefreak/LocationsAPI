using System;
using System.Collections.Generic;
using System.Text;

namespace Locations.Core.Models.Images
{
    public class User
    {
        public string id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public Photo photo { get; set; }
    }
}
