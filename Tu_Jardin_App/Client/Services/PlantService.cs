using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Tu_Jardin_App.Shared;
using Tu_Jardin_App.Shared.Models;

namespace Tu_Jardin_App.Client.Services
{
    public class PlantService : IPlantService
    {
        private readonly HttpClient _httpClient;

        public List<Plant> plants { get; set; } = new List<Plant>();

        public List<Achieve> achieves { get; set; } = new List<Achieve>();

        public List<User> users { get; set; } = new List<User>();


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

        public async Task<User> GetUser(string email)
        {
            return await _httpClient.GetFromJsonAsync<User>($"api/plant/users/{email}");
        }

        public async Task<List<Plant>> CreatePlant(Plant planta)
        {
            var result = await _httpClient.PostAsJsonAsync<Plant>($"api/plant", planta);
            var plants = await result.Content.ReadFromJsonAsync<List<Plant>>();
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
            return plants;
        }

        public async Task<List<Plant>> DeletePlant(int id)
        {
            var result = await _httpClient.DeleteAsync($"api/plant/{id}");
            var plants = await result.Content.ReadFromJsonAsync<List<Plant>>();
            return plants;
        }

        public async Task<List<Achieve>> DeleteAchieve(int id)
        {
            var result = await _httpClient.DeleteAsync($"api/plant/achievements/{id}");
            var achieves = await result.Content.ReadFromJsonAsync<List<Achieve>>();
            return achieves;
        }

        public async Task<List<Achieve>> CreateAchieve(Achieve achieve)
        {
            var result = await _httpClient.PostAsJsonAsync<Achieve>($"api/plant/achievements", achieve);
            var achieves = await result.Content.ReadFromJsonAsync<List<Achieve>>();
            return achieves;
        }

        public async Task<Achieve> GetAchieve(int id)
        {
            return await _httpClient.GetFromJsonAsync<Achieve>($"api/plant/achievements/{id}");
        }

        public async Task<List<Achieve>> UpdateAchieve(Achieve achieve, int id)
        {
            var result = await _httpClient.PutAsJsonAsync<Achieve>($"api/plant/achievements/{id}", achieve);
            var achieves = await result.Content.ReadFromJsonAsync<List<Achieve>>();
            return achieves;
        }

        public async Task<List<User>> UpdateUser(User user, string email)
        {
            var result = await _httpClient.PutAsJsonAsync<User>($"api/plant/users/{email}", user);
            var users = await result.Content.ReadFromJsonAsync<List<User>>();
            return users;
        }

        public async Task<List<User>> GetUsers()
        {
            users = await _httpClient.GetFromJsonAsync<List<User>>("api/plant/users");
            return users;
        }

        public async Task<List<User>> CreateUser(User user)
        {
            var result = await _httpClient.PostAsJsonAsync<User>($"api/plant/users", user);
            var users = await result.Content.ReadFromJsonAsync<List<User>>();
            return users;
        }

        public async Task<List<User>> DeleteUser(string email)
        {
            var result = await _httpClient.DeleteAsync($"api/plant/users/{email}");
            var users = await result.Content.ReadFromJsonAsync<List<User>>();
            return users;
        }
    }
}
