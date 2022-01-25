using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entity;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocationsController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public LocationsController(ApplicationDbContext db)
        {
            this._db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Location>>> GetLocations()
        {
            var locations = await _db.Locations.ToListAsync();
            return Ok(locations);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Location>> GetLocations(int id) => await _db.Locations.FindAsync(id);
    }
}