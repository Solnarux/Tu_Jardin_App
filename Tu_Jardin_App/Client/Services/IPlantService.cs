using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tu_Jardin_App.Shared;
using Tu_Jardin_App.Shared.Models;

namespace Tu_Jardin_App.Client.Services
{
    public interface IPlantService
    {
        public List<Plant> plants { get; set; }

        public List<Achieve> achieves { get; set; }

        public List<User> users { get; set; }


        Task<List<Plant>> GetPlants();

        Task<List<Achieve>> GetAchieves();

        Task<List<User>> GetUsers();

        Task<List<Achieve>> CreateAchieve(Achieve achieve);

        Task<Plant> GetPlant(int id);

        Task<Achieve> GetAchieve(int id);
        
        Task<User> GetUser(string email);

        Task<List<Plant>> CreatePlant(Plant planta);

        Task<List<User>> CreateUser(User user);

        Task<List<Plant>> UpdatePlant(Plant planta, int id);

        Task<List<Achieve>> UpdateAchieve(Achieve achieve, int id);

        Task<List<User>> UpdateUser(User user, string email);

        Task<List<Plant>> DeletePlant(int id);

        Task<List<Achieve>> DeleteAchieve(int id);
        Task<List<User>> DeleteUser(string email);
    }
}
