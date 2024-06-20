using System.ComponentModel.DataAnnotations;

namespace BlazorLearning.Models
{
    public class Pet
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="Imię jest wymagane")]
        [MinLength(3, ErrorMessage = "Imię musi mieć minimum 3 znaki")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Gatunek jest wymagany")]
        public string Species { get; set; } = string.Empty;
        [Required(ErrorMessage = "Rasa jest wymagana")]
        public string Race { get; set; } = string.Empty;
        [Required(ErrorMessage = "Rozmiar jest wymagany")]
        public string Size { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        [Required(ErrorMessage = "Zdjęcie jest wymagane")]
        public string Photo_Path { get; set; } = string.Empty;

    }
}
