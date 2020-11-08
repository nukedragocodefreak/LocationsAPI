using Locations.Core.Models;
using Locations.Core.Models.Parameters;
using Locations.Core.Models.Venues;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Locations.Application.Interfaces
{
    public interface IListLocations
    {
        Task<SearchVenues> GetLocations(VenueParameters venueParameters);
    }
}
