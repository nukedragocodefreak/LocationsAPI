using Locations.Application.Interfaces;
using Locations.Core.Models.Parameters;
using Locations.Core.Models.Venues;
using Locations.Infrastructure.Utility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Locations.Infrastructure.Repositories
{
    public class ListLocations : IListLocations
    {
        public async Task<SearchVenues> GetLocations(VenueParameters venueParameters)
        {
            var searchvenues = new SearchVenues();
            venueParameters.Intent = "browse";
            var result = await Urls.GetStringAsync(Urls.BaseUri+"venues/search?client_id="+Urls.client_id+ "&client_secret=" + Urls.client_secret+"&v=20190425&near="+venueParameters.Near+ "&intent="+venueParameters.Intent+ "&radius="+venueParameters.Radius+ "&limit="+venueParameters.Limit);
            //https://api.foursquare.com/v2/venues/search?client_id=3QLIE2CJOVDRDUPC005VKY5S14ONGS4LJH3V12GVYS3IIYDR&client_secret=4H43YM0HRH3LUNI0WD3A2FRHJVMOFGTKA1FI1JB3XCQKOOIL&v=20190425&near=harare&intent=browse&radius=10000&limit=10
            var result_venues = JsonConvert.DeserializeObject<SearchVenues>(result);
            return result_venues;
        }
    }
}
