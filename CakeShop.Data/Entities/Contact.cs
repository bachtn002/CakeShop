using CakeShop.Data.Enums;

namespace CakeShop.Data.Entities
{
    public class Contact
    {
        private int id;
        private string name;
        private string email;
        private string phoneNumber;
        private string message;
        private Status status;




        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Message { get => message; set => message = value; }
        public Status Status { get => status; set => status = value; }
    }
}
