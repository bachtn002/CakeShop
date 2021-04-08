using System;

namespace CakeShop.Service.Users.Model
{
    public class ViewModelUsers
    {
        private Guid id;
        private string firstName;
        private string lastName;
        private string userName;
        private string phoneNumber;
        private string email;

        public Guid Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string UserName { get => userName; set => userName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
    }
}
