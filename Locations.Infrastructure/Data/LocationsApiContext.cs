using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Locations.Core.Models.Users;

namespace Locations.Api.Models
{
    public class LocationsApiContext : DbContext
    {
        public LocationsApiContext (DbContextOptions<LocationsApiContext> options)
            : base(options)
        {
        }

        public DbSet<Locations.Core.Models.Users.Users> Users { get; set; }
        public DbSet<Locations.Core.Models.SavedData.SavedImages> Images { get; set; }
        public DbSet<Locations.Core.Models.SavedData.SavedLocations> Locations { get; set; }
    }
}
