using System.ComponentModel.DataAnnotations;

namespace CoreProject.Areas.Writer.Models
{
    public class UserLoginVM
    {
        [Display(Name ="Kullanıcı Adı")]
        [Required(ErrorMessage = "Kulllanıcı Adını giriniz.")]
        public string UserName { get; set;}
        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifrenizi giriniz.")]
        public string Password { get; set;}
    }
}
