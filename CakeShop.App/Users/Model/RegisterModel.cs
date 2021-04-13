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
        [Required(ErrorMessage = "Username is required")]
        public string UserName { get => userName; set => userName = value; }





        [Display(Name = "Mật khẩu")]
        /*[DataType(DataType.Password)]*/
        [Required(ErrorMessage = "Password is required")]
        [MinLength(8, ErrorMessage = "Password at least 8 character")]
        [RegularExpression(@"(^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$)"
                , ErrorMessage = "Password at least one uppercase letter, one lowercase letter, one number and one special character")]
        public string PassWord { get => passWord; set => passWord = value; }






        [Display(Name = "Nhập lại mật khẩu")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Confirm password is required")]
        [Compare(nameof(PassWord), ErrorMessage = "Confirm password not match")]
        public string ConfirmPassWord { get => confirmPassWord; set => confirmPassWord = value; }
        [Display(Name = "Họ, tên đệm")]
        [Required(ErrorMessage = "Firtsname is required")]
        public string FirstName { get => firstName; set => firstName = value; }
        [Display(Name = "Tên")]
        [Required(ErrorMessage = "Lastname is required")]
        public string LastName { get => lastName; set => lastName = value; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get => email; set => email = value; }
        [Display(Name = "Số điện thoại")]
        [Required(ErrorMessage = "Phone is required")]
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
    }
}
