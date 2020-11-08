using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Locations.Core.Models.Image;
using Locations.Core.Models.Parameters;
using Locations.Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Locations.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageDetailsController : ControllerBase
    {
        private readonly ImageSpecific _requestService;

        public ImageDetailsController(ImageSpecific requestService)
        {
            _requestService = requestService;
        }

        [HttpPost]
        public async Task<SearchImage> GetListLocations(ImageParameters imageParameters)

        {
            var result = await _requestService.GetImageDetails(imageParameters);
            return result;
        }
    }
}