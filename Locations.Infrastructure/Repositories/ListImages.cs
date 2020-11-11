using Locations.Api.Models;
using Locations.Application.Interfaces;
using Locations.Core.Models.Images;
using Locations.Core.Models.Parameters;
using Locations.Core.Models.SavedData;
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
        private readonly LocationsApiContext _context;

        public ListImages(LocationsApiContext context)
        {
            _context = context;
        }

        public async Task<SearchImages> GetImageLocations(ImagesParameters imageParameters)
        {
            var searchimages = new SearchImages();
            imageParameters.Group = "venue";
            var result = await Urls.GetStringAsync(Urls.BaseUri+ "venues/"+imageParameters.VenueID+ "/photos?client_id="+Urls.client_id+ "&client_secret="+Urls.client_secret+ "&v=20190425&group=" + imageParameters.Group+ "&limit="+ imageParameters.Limit);
            
            var result_images = JsonConvert.DeserializeObject<SearchImages>(result);

            for(int i = 0; i < result_images.response.photos.items.Length; i++ )
            {
                var saveimages = new SavedImages
                {
                    Id = result_images.response.photos.items[i].id,
                    CreatedAt = result_images.response.photos.items[i].createdAt.ToString(),
                    Prefix = result_images.response.photos.items[i].prefix,
                    Suffix = result_images.response.photos.items[i].suffix,
                    Height = result_images.response.photos.items[i].height,
                    Width = result_images.response.photos.items[i].width
                };

                _context.Images.Add(saveimages);
                await _context.SaveChangesAsync();
            }
           
            return result_images;
        }
    }
}
