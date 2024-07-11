using System.ComponentModel.DataAnnotations;

namespace Shopping.Models
{
    public class UserModel 
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Nhập Username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Nhập email"),EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Password), Required(ErrorMessage = "Nhập password")]

        public string Password { get; set; }
       
    }
}
