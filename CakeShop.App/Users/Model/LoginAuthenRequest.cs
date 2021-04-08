namespace CakeShop.Service.Users.Model
{
    public class LoginAuthenticateRequest
    {
        private string userName;
        private string passWord;
        private bool rememberMe;

        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public bool RememberMe { get => rememberMe; set => rememberMe = value; }
    }
}
