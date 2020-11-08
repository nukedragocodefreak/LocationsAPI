using Locations.Core.Models.Parameters;
using Locations.Core.Models.Images;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Locations.Application.Interfaces
{
    public interface IListImages
    {
        Task<SearchImages> GetLocations(ImagesParameters imageParameters);
    }
}
