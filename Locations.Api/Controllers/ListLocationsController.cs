using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Locations.Core.Models.Parameters;
using Locations.Core.Models.Venues;
using Locations.Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Locations.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListLocationsController : ControllerBase
    {
        private readonly ListLocations _requestService;

        public ListLocationsController(ListLocations requestService)
        {
            _requestService = requestService;
        }

        [HttpPost]
        public async Task<SearchVenues> GetImages(VenueParameters venueParameters)
        {
            var result = await _requestService.GetLocations(venueParameters);
            return result;
        }
    }
}