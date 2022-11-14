using System.ComponentModel.DataAnnotations;

namespace NetCore.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adını girin.")]
        public string username { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi adını girin.")]
        public string password { get; set; }
    }
}
