using System;
using System.Collections.Generic;
using System.Text;

namespace Locations.Core.Models.Image
{
    public class User
    {
        public string id { get; set; }
        public bool isSanctioned { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public Photo1 photo { get; set; }
    }
}
