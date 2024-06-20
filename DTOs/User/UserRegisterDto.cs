using System.ComponentModel.DataAnnotations;

namespace BlazorLearning.DTOs.User
{
	public class UserRegisterDto
	{
		[Required(ErrorMessage = "Imię jest wymagane")]
		public string Name { get; set; } = string.Empty;

		[Required(ErrorMessage = "Nazwisko jest wymagane")]
		public string Surname { get; set; } = string.Empty;

		[Required(ErrorMessage = "Adres E-mail jest wymagany")]
		[EmailAddress(ErrorMessage = "Wprowadzony E-mail jest niepoprawny")]
		public string Email { get; set; } = string.Empty;

		[Required(ErrorMessage = "Hasło jest wymagane")]
		public string Password { get; set; } = string.Empty;
		[Required(ErrorMessage = "Pole nie może być puste")]
		[Compare(nameof(Password), ErrorMessage ="Hasła nie są takie same")]
		public string ConfirmPassword { get; set; } = string.Empty;
    }
}
