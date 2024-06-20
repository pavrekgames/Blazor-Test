using BlazorLearning.DTOs.User;
using BlazorLearning.Interfaces;
using BlazorLearning.Models;

namespace BlazorLearning.Services
{
	public class UserApiService: IUserApiService
	{
		private readonly HttpClient httpClient;

        public UserApiService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> Register(UserRegisterDto user)
		{
			return await httpClient.PostAsJsonAsync("register", user);
		}

        public async Task<IEnumerable<UserPetOwnerDto>> GetUsersPetOwners()
        {
            return await httpClient.GetFromJsonAsync<UserPetOwnerDto[]>("pet-owners");
        }


    }
}
