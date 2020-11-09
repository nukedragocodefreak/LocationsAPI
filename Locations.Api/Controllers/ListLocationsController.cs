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
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ListlocationsController : ControllerBase
    {
        private readonly ListLocations _requestService;

        public ListlocationsController(ListLocations requestService)
        {
            _requestService = requestService;
        }

        [HttpPost]
        public async Task<SearchVenues> GetLocations(VenueParameters venueParameters)
        {
            var result = await _requestService.GetLocations(venueParameters);
            return result;
        }
    }
}