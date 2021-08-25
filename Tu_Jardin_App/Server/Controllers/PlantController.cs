using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using Tu_Jardin_App.Server.Data;
using Tu_Jardin_App.Shared.Models;

namespace Tu_Jardin_App.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantController : ControllerBase
    {

        static List<Achieve> achieves = new List<Achieve>
        {
            new Achieve {Semillero = true, Agricultor = true},
            new Achieve {Riego = true, Cosecha = true}
        };

        static List<Plant> plantas = new List<Plant> {
            new Plant {Id = 1, Name = "Jesus", Type = "Salvia", Img = "/images/Aromáticas.png", Owner = "David Herrera", Achievements = achieves[0], Seeddate = DateTime.Now },
            new Plant {Id = 2, Name = "Alberto", Type = "Cannabis Indica", Img = "/images/Cannabis.png", Owner = "David Herrera", Achievements = achieves[1], Seeddate = DateTime.Now }
        };

        private readonly DataContext _context;

        public PlantController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetPlants()
        {
            return base.Ok(await GetDbPlants());
        }

        private async Task<List<Plant>> GetDbPlants()
        {
            return await _context.Plants.Include(p => p.Achievements).ToListAsync();
        }

        [HttpGet("achievements")]
        public async Task<IActionResult> GetAchieves()
        {
            return Ok(await _context.Achieves.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPlant(int id)
        {
            var plant = await _context.Plants.Include(p => p.Achievements).FirstOrDefaultAsync(p => p.Id == id);
            if (plant == null)
            {
                return NotFound("Plant does not exist");
            }

            return Ok(plant);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePlant(Plant planta)
        {
            _context.Plants.Add(planta);

            await _context.SaveChangesAsync();
            
            return Ok(await GetDbPlants());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePlant(Plant planta, int id)
        {
            var dbplanta = await _context.Plants.Include(p => p.Achievements).FirstOrDefaultAsync(p => p.Id == id);
            if (dbplanta == null)
            {
                return NotFound("Plant does not exist");
            }

            var index = plantas.IndexOf(dbplanta);

            dbplanta.Name = planta.Name;
            dbplanta.Type = planta.Type;
            dbplanta.Seeddate = planta.Seeddate;
            dbplanta.Img = planta.Img;
            dbplanta.Owner = planta.Owner;
            dbplanta.AchievementsId = planta.AchievementsId;

            await _context.SaveChangesAsync();

            return Ok(await GetDbPlants());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlant(int id)
        {
            var dbplanta = await _context.Plants.Include(p => p.Achievements).FirstOrDefaultAsync(p => p.Id == id);
            if (dbplanta == null)
            {
                return NotFound("Plant does not exist");
            }

            _context.Plants.Remove(dbplanta);

            await _context.SaveChangesAsync();

            return Ok(await GetDbPlants());
        }
    }
}
