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

            var result_image = JsonConvert.DeserializeObject<SearchImage>(result);
            return result_image;
         
        }
    }
}
