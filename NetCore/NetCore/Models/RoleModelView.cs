using System.ComponentModel.DataAnnotations;

namespace NetCore.Models
{
    public class RoleModelView
    {
        [Required(ErrorMessage = "Lütfen Rol Adı Giriniz.")]
        public string Name { get; set; }
    }

}
