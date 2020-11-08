﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Locations.Core.Models.Images;
using Locations.Core.Models.Parameters;
using Locations.Core.Models.Venues;
using Locations.Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Locations.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesForLocationController : ControllerBase
    {
        private readonly ListImages _requestService;

        public ImagesForLocationController(ListImages requestService)
        {
            _requestService = requestService;
        }

        [HttpPost]

        public async Task<SearchImages> GetImageLocations(ImagesParameters imagesParameters)
        {
            var result = await _requestService.GetImageLocations(imagesParameters);
            return result;
        }
    }
}