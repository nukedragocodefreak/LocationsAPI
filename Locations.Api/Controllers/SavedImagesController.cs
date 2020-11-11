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
    [ApiExplorerSettings(IgnoreApi = true)]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class SavedImagesController : ControllerBase
    {
        private readonly LocationsApiContext _context;

        public SavedImagesController(LocationsApiContext context)
        {
            _context = context;
        }

        // GET: api/SavedImages
        [HttpGet]
        public IEnumerable<SavedImages> GetImages()
        {
            return _context.Images;
        }

        // GET: api/SavedImages/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSavedImages([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var savedImages = await _context.Images.FindAsync(id);

            if (savedImages == null)
            {
                return NotFound();
            }

            return Ok(savedImages);
        }

        // PUT: api/SavedImages/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSavedImages([FromRoute] string id, [FromBody] SavedImages savedImages)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != savedImages.Id)
            {
                return BadRequest();
            }

            _context.Entry(savedImages).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SavedImagesExists(id))
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

        // POST: api/SavedImages
        [HttpPost]
        public async Task<IActionResult> PostSavedImages([FromBody] SavedImages savedImages)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Images.Add(savedImages);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSavedImages", new { id = savedImages.Id }, savedImages);
        }

        // DELETE: api/SavedImages/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSavedImages([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var savedImages = await _context.Images.FindAsync(id);
            if (savedImages == null)
            {
                return NotFound();
            }

            _context.Images.Remove(savedImages);
            await _context.SaveChangesAsync();

            return Ok(savedImages);
        }

        private bool SavedImagesExists(string id)
        {
            return _context.Images.Any(e => e.Id == id);
        }
    }
}