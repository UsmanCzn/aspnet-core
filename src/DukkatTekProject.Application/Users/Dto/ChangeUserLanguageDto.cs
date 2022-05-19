using System.ComponentModel.DataAnnotations;

namespace DukkatTekProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}