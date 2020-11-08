using Locations.Application.Interfaces;
using Locations.Core.Models.Image;
using Locations.Core.Models.Parameters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Locations.Infrastructure.Repositories
{
    public class ImageSpecific : IImageSpecific
    {
        public Task<SearchImage> GetLocations(ImageParameters imageParameters)
        {
            throw new NotImplementedException();
        }
    }
}
