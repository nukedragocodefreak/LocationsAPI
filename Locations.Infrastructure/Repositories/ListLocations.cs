using Locations.Application.Interfaces;
using Locations.Core.Models.Parameters;
using Locations.Core.Models.Venues;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Locations.Infrastructure.Repositories
{
    public class ListLocations : IListLocations
    {
        public async Task<SearchVenues> GetLocations(VenueParameters venueParameters)
        {
            throw new NotImplementedException();
        }
    }
}
