using System;
using System.Collections.Generic;
using System.Text;

namespace Locations.Core.Models.Images
{
    public class Item
    {
        public string id { get; set; }
        public int createdAt { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public User user { get; set; }
        public string visibility { get; set; }
    }
}
