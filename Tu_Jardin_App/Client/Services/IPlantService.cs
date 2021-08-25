using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tu_Jardin_App.Shared.Models;

namespace Tu_Jardin_App.Client.Services
{
    public interface IPlantService
    {
        event Action OnChange;

        public List<Plant> plants { get; set; }

        public List<Achieve> achieves { get; set; }

        Task<List<Plant>> GetPlants();

        Task<List<Achieve>> GetAchieves();

        Task<Plant> GetPlant(int id);

        Task<List<Plant>> CreatePlant(Plant planta);

        Task<List<Plant>> UpdatePlant(Plant planta, int id);

        Task<List<Plant>> DeletePlant(int id);
    }
}
