using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using Tu_Jardin_App.Server.Data;
using Tu_Jardin_App.Shared;
using Tu_Jardin_App.Shared.Models;

namespace Tu_Jardin_App.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantController : ControllerBase
    {


        private readonly DataContext _context;

        public PlantController(DataContext context)
        {
            _context = context;
        }

        private async Task<List<Plant>> GetDbPlants()
        {
            return await _context.Plants.Include(p => p.Achievements).ToListAsync();
        }

        private async Task<List<Achieve>> GetDbAchieves()
        {
            return await _context.Achieves.ToListAsync();
        }

        private async Task<List<User>> GetDbUsers()
        {
            return await _context.Users.ToListAsync();
        }

        [HttpGet]
        public async Task<IActionResult> GetPlants()
        {
            return Ok(await GetDbPlants());
        }

        [HttpGet("users")]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await GetDbUsers());
        }
        

        [HttpGet("achievements")]
        public async Task<IActionResult> GetAchieves()
        {
            return Ok(await GetDbAchieves());
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

        [HttpGet("achievements/{id}")]
        public async Task<IActionResult> GetAchieve(int id)
        {
            var achieve = await _context.Achieves.FirstOrDefaultAsync(a => a.Id == id);
            if (achieve == null)
            {
                return NotFound("Achievement does not exist");
            }

            return Ok(achieve);
        }

        [HttpGet("users/{email}")]
        public async Task<IActionResult> GetUser(string email)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
            if (user == null)
            {
                return NotFound("User does not exist");
            }

            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePlant(Plant planta)
        {
            
            _context.Plants.Add(planta);

            await _context.SaveChangesAsync();
            
            return Ok(await GetDbPlants());
        }

        [HttpPost("achievements")]
        public async Task<IActionResult> CreateAchieve(Achieve achieve)
        {
            _context.Achieves.Add(achieve);

            await _context.SaveChangesAsync();

            return Ok(await GetDbAchieves());
        }

        [HttpPost("users")]
        public async Task<IActionResult> CreateUser(User user)
        {
            _context.Users.Add(user);

            await _context.SaveChangesAsync();

            return Ok(await GetDbUsers());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePlant(Plant planta, int id)
        {
            var dbplanta = await _context.Plants.Include(p => p.Achievements).FirstOrDefaultAsync(p => p.Id == id);
            if (dbplanta == null)
            {
                return NotFound("Plant does not exist");
            }

            dbplanta.Name = planta.Name;
            dbplanta.Type = planta.Type;
            dbplanta.Seeddate = planta.Seeddate;
            dbplanta.Img = planta.Img;
            dbplanta.Owner = planta.Owner;
            dbplanta.AchievementsId = planta.AchievementsId;
            dbplanta.Email = planta.Email;

            await _context.SaveChangesAsync();

            return Ok(await GetDbPlants());
        }

        [HttpPut("achievements/{id}")]
        public async Task<IActionResult> UpdateAchieve(Achieve achieve, int id)
        {
            var dbachieve = await _context.Achieves.FirstOrDefaultAsync(a => a.Id == id);
            if (dbachieve == null)
            {
                return NotFound("Achievement does not exist");
            }

            dbachieve.Agricultor = achieve.Agricultor;
            dbachieve.Jardin = achieve.Jardin;
            dbachieve.Cosecha = achieve.Cosecha;
            dbachieve.Jardinero = achieve.Jardinero;
            dbachieve.Lluvia = achieve.Lluvia;
            dbachieve.Riego = achieve.Riego;
            dbachieve.Vida = achieve.Vida;
            dbachieve.Semillero = achieve.Semillero;
            dbachieve.Hermitano = achieve.Hermitano;
            dbachieve.Guardabosques = achieve.Guardabosques;

            await _context.SaveChangesAsync();

            return Ok(await GetDbAchieves());
        }

        [HttpPut("users/{email}")]
        public async Task<IActionResult> UpdateUser(User user, string email)
        {
            var dbuser = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
            if (dbuser == null)
            {
                return NotFound("User does not exist");
            }

            dbuser.UserName = user.UserName;
            dbuser.Img = user.Img;
            dbuser.Points = user.Points;
            dbuser.Plants = user.Plants;

            await _context.SaveChangesAsync();

            return Ok(await GetDbUsers());
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

        [HttpDelete("achievements/{id}")]
        public async Task<IActionResult> DeleteAchieve(int id)
        {
            var dbachieve = await _context.Achieves.FirstOrDefaultAsync(a => a.Id == id);
            if (dbachieve == null)
            {
                return NotFound("Achievement does not exist");
            }

            _context.Achieves.Remove(dbachieve);

            await _context.SaveChangesAsync();

            return Ok(await GetDbAchieves());
        }

        [HttpDelete("users/{email}")]
        public async Task<IActionResult> DeleteUser(string email)
        {
            var dbuser = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
            if (dbuser == null)
            {
                return NotFound("User does not exist");
            }

            _context.Users.Remove(dbuser);

            await _context.SaveChangesAsync();

            return Ok(await GetDbUsers());
        }


    }
}
