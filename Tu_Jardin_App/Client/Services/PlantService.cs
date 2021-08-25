using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Tu_Jardin_App.Shared.Models;

namespace Tu_Jardin_App.Client.Services
{
    public class PlantService : IPlantService
    {
        private readonly HttpClient _httpClient;

        public List<Plant> plants { get; set; } = new List<Plant>();

        public List<Achieve> achieves { get; set; } = new List<Achieve>();

        public event Action OnChange;

        public PlantService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Plant>> GetPlants()
        {
            plants = await _httpClient.GetFromJsonAsync<List<Plant>>("api/plant");
            return plants;
        }
        
        public async Task<Plant> GetPlant(int id)
        {
            return await _httpClient.GetFromJsonAsync<Plant>($"api/plant/{id}");
        }

        public async Task<List<Plant>> CreatePlant(Plant planta)
        {
            var result = await _httpClient.PostAsJsonAsync<Plant>($"api/plant", planta);
            var plants = await result.Content.ReadFromJsonAsync<List<Plant>>();
            OnChange.Invoke();
            return plants;
        }

        public async Task<List<Achieve>> GetAchieves()
        {   
            achieves = await _httpClient.GetFromJsonAsync<List<Achieve>>("api/plant/achievements");
            return achieves;
        }

        public async Task<List<Plant>> UpdatePlant(Plant planta, int id)
        {
            var result = await _httpClient.PutAsJsonAsync<Plant>($"api/plant/{id}", planta);
            var plants = await result.Content.ReadFromJsonAsync<List<Plant>>();
            OnChange.Invoke();
            return plants;
        }

        public async Task<List<Plant>> DeletePlant(int id)
        {
            var result = await _httpClient.DeleteAsync($"api/plant/{id}");
            var plants = await result.Content.ReadFromJsonAsync<List<Plant>>();
            OnChange.Invoke();
            return plants;
        }
    }
}
