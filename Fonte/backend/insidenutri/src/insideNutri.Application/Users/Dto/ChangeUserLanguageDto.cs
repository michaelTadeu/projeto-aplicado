using System.ComponentModel.DataAnnotations;

namespace insideNutri.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}