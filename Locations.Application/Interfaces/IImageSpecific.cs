using Locations.Core.Models.Image;
using Locations.Core.Models.Parameters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Locations.Application.Interfaces
{
    public interface IImageSpecific
    {
        Task<SearchImage> GetImageDetails(ImageParameters imageParameters);
    }
}
