using System.ComponentModel.DataAnnotations;

namespace CoreProject.Areas.Writer.Models
{
    public class UserRegisterVM
    {
        [Required(ErrorMessage = "Bu alan boş geçilemez!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez!")]
        public string SurName { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez!")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez!")]
        [Compare("Password", ErrorMessage = "Şifreler uyumlu değil!")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez!")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez!")]
        public string ImageURL { get; set; }
    }
}
