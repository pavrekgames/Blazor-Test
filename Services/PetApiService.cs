using BlazorLearning.Interfaces;
using BlazorLearning.Models;

namespace BlazorLearning.Services
{
    public class PetApiService : IPetApiService
    {
        private readonly HttpClient httpClient;

        public PetApiService(HttpClient httpClient)
        {

            this.httpClient = httpClient;

        }

        public async Task<IEnumerable<Pet>> GetNewestPets()
        {
            return await httpClient.GetFromJsonAsync<Pet[]>("newest-pets");
        }

        public async Task<Pet> GetPetById(int id)
        {
            return await httpClient.GetFromJsonAsync<Pet>($"pets-to-adopt/{id}");
        }
    }
}
