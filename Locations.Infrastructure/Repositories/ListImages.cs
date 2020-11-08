using Locations.Application.Interfaces;
using Locations.Core.Models.Images;
using Locations.Core.Models.Parameters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Locations.Infrastructure.Repositories
{
    public class ListImages : IListImages
    {
        public Task<SearchImages> GetLocations(ImagesParameters imageParameters)
        {
            throw new NotImplementedException();
        }
    }
}
