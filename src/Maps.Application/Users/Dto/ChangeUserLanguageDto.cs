using System.ComponentModel.DataAnnotations;

namespace Maps.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}