using System.ComponentModel.DataAnnotations;

namespace CakeShop.Service.Users.Model
{
    public class LoginAuthenRequest
    {
        private string userName;
        private string passWord;
        private bool rememberMe;

        [Required(ErrorMessage = "Username is required")]
        public string UserName { get => userName; set => userName = value; }
        [Required(ErrorMessage ="Password is required")]
        [MinLength(6,ErrorMessage ="Password at least 6 character")]
        public string PassWord { get => passWord; set => passWord = value; }
        public bool RememberMe { get => rememberMe; set => rememberMe = value; }
    }
}
