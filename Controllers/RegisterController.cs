using BlazorLearning.DTOs.User;
using BlazorLearning.Helpers;
using BlazorLearning.Interfaces;
using BlazorLearning.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorLearning.Controllers
{
    public class RegisterBase: ComponentBase
    {
        [Inject]
        private HttpClient httpClient {  get; set; }
        [Inject]
        private IUserApiService userApiService { get; set; }
		[Inject]
		private NavigationManager navigationManager { get; set; }
		[Inject]
		private JsConsole jsConsole { get; set; }

        public UserRegisterDto userRegister = new();

        public string errorMessage = String.Empty;

      /*  public RegisterBase(HttpClient httpClient, IUserApiService userApiService, NavigationManager navigationManager, JsConsole jsConsole)
        {
            //this.httpClient = httpClient;
            //this.userApiService = userApiService;
            this.navigationManager = navigationManager;
            this.jsConsole = jsConsole;
        } */

        public async Task OnSubmit()
        {
            errorMessage = string.Empty;
            var response = await userApiService.Register(userRegister);
            await jsConsole.LogAsync("OnSubmit");

            if (response.IsSuccessStatusCode)
            {
                navigationManager.NavigateTo("/login");
            }
            else
            {
                //errorMessage = "Podany e-mail już istnieje! Wprowadź inny adres e-mail";
                errorMessage = await response.Content.ReadAsStringAsync();

            }
        }

    }
}
