using Locations.Application.Interfaces;
using Locations.Core.Models.Images;
using Locations.Core.Models.Parameters;
using Locations.Infrastructure.Utility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Locations.Infrastructure.Repositories
{
    public class ListImages : IListImages
    {
        public async Task<SearchImages> GetImageLocations(ImagesParameters imageParameters)
        {
            var searchimages = new SearchImages();
            imageParameters.Group = "venue";
            var result = await Urls.GetStringAsync(Urls.BaseUri+ "venues/"+imageParameters.VenueID+ "/photos?client_id="+Urls.client_id+ "&client_secret="+Urls.client_secret+ "&v=20190425&group=" + imageParameters.Group+ "&limit="+ imageParameters.Limit);
            //https://api.foursquare.com/v2/venues/4b81bd7af964a5202fbb30e3/photos?client_id=3QLIE2CJOVDRDUPC005VKY5S14ONGS4LJH3V12GVYS3IIYDR&client_secret=4H43YM0HRH3LUNI0WD3A2FRHJVMOFGTKA1FI1JB3XCQKOOIL&v=20190425&group=venue&limit=10
            var result_images = JsonConvert.DeserializeObject<SearchImages>(result);
            return result_images;
        }
    }
}
