using System;
using System.ComponentModel.DataAnnotations;

namespace CakeShop.Service.Users.Model
{
    public class RegisterModel
    {

        private string userName;
        private string passWord;
        private string confirmPassWord;
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private string email;
        private string phoneNumber;

        [Display(Name = "Tên đăng nhập")]
        public string UserName { get => userName; set => userName = value; }
        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        public string PassWord { get => passWord; set => passWord = value; }
        [Display(Name = "Nhập lại mật khẩu")]
        [DataType(DataType.Password)]
        public string ConfirmPassWord { get => confirmPassWord; set => confirmPassWord = value; }
        [Display(Name = "Họ, tên đệm")]
        public string FirstName { get => firstName; set => firstName = value; }
        [Display(Name = "Tên")]
        public string LastName { get => lastName; set => lastName = value; }
        [Display(Name = "Email")]
        public string Email { get => email; set => email = value; }
        [Display(Name = "Số điện thoại")]
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
    }
}
