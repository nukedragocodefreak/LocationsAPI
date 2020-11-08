using System;
using System.Collections.Generic;
using System.Text;

namespace Locations.Core.Models.Image
{
    public class Photo
    {
        public string id { get; set; }
        public int createdAt { get; set; }
        public Source source { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public User user { get; set; }
        public string visibility { get; set; }
        public Venue venue { get; set; }
    }
}
