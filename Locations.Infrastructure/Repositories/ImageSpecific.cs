using Locations.Application.Interfaces;
using Locations.Core.Models.Image;
using Locations.Core.Models.Parameters;
using Locations.Infrastructure.Utility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Locations.Infrastructure.Repositories
{
    public class ImageSpecific : IImageSpecific
    {
        public async Task<SearchImage> GetImageDetails(ImageParameters imageParameters)
        {
            var searchimage = new SearchImage();
            var result = await Urls.GetStringAsync(Urls.BaseUri+ "photos/"+imageParameters.PhotoID+ "?client_id="+Urls.client_id + "&client_secret="+Urls.client_secret+ "&v=20190425");
            //https://api.foursquare.com/v2/photos/5fa691869e81c46739fde8f5?client_id=3QLIE2CJOVDRDUPC005VKY5S14ONGS4LJH3V12GVYS3IIYDR&client_secret=4H43YM0HRH3LUNI0WD3A2FRHJVMOFGTKA1FI1JB3XCQKOOIL&v=20190425
            var result_image = JsonConvert.DeserializeObject<SearchImage>(result);
            return result_image;
         
        }
    }
}
