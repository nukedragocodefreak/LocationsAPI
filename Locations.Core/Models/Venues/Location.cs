using System;
using System.Collections.Generic;
using System.Text;

namespace Locations.Core.Models.Venues
{
    public class Location
    {
        public float lat { get; set; }
        public float lng { get; set; }
        public Labeledlatlng[] labeledLatLngs { get; set; }
        public string cc { get; set; }
        public string country { get; set; }
        public string[] formattedAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string address { get; set; }
        public string crossStreet { get; set; }
    }
}
