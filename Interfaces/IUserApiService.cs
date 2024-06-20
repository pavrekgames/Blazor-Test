using BlazorLearning.DTOs.User;
using System.Collections;

namespace BlazorLearning.Interfaces
{
	public interface IUserApiService
	{
		Task<HttpResponseMessage> Register(UserRegisterDto user);
		Task<IEnumerable<UserPetOwnerDto>> GetUsersPetOwners();
	}
}
