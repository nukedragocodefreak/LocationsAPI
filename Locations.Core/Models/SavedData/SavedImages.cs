using System;
using System.Collections.Generic;
using System.Text;

namespace Locations.Core.Models.SavedData
{
    public class SavedImages
    {
        public string Id { get; set; }
        public string CreatedAt { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

    }
}
