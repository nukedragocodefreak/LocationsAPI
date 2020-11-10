using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Locations.Api.Models;
using Locations.Core.Models.SavedData;

namespace Locations.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SavedLocationsController : ControllerBase
    {
        private readonly LocationsApiContext _context;

        public SavedLocationsController(LocationsApiContext context)
        {
            _context = context;
        }

        // GET: api/SavedLocations
        [HttpGet]
        public IEnumerable<SavedLocations> GetLocations()
        {
            return _context.Locations;
        }

        // GET: api/SavedLocations/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSavedLocations([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var savedLocations = await _context.Locations.FindAsync(id);

            if (savedLocations == null)
            {
                return NotFound();
            }

            return Ok(savedLocations);
        }

        // PUT: api/SavedLocations/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSavedLocations([FromRoute] string id, [FromBody] SavedLocations savedLocations)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != savedLocations.Id)
            {
                return BadRequest();
            }

            _context.Entry(savedLocations).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SavedLocationsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/SavedLocations
        [HttpPost]
        public async Task<IActionResult> PostSavedLocations([FromBody] SavedLocations savedLocations)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Locations.Add(savedLocations);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSavedLocations", new { id = savedLocations.Id }, savedLocations);
        }

        // DELETE: api/SavedLocations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSavedLocations([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var savedLocations = await _context.Locations.FindAsync(id);
            if (savedLocations == null)
            {
                return NotFound();
            }

            _context.Locations.Remove(savedLocations);
            await _context.SaveChangesAsync();

            return Ok(savedLocations);
        }

        private bool SavedLocationsExists(string id)
        {
            return _context.Locations.Any(e => e.Id == id);
        }
    }
}