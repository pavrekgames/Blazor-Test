using BlazorLearning.Models;

namespace BlazorLearning.Interfaces
{
    public interface IPetApiService
    {
        Task<IEnumerable<Pet>> GetNewestPets();
        Task<Pet> GetPetById(int id);

    }
}
