using System.ComponentModel.DataAnnotations;

namespace Shopping.Models
{
    public class LoginViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nhập Username")]
        public string Username { get; set; }
        [DataType(DataType.Password), Required(ErrorMessage = "Nhập password")]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}
