
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CakeShop.Service.Users.Model;
using FluentValidation;

namespace CakeShop.Service.Users.Service
{
    public class LoginModelValidator : AbstractValidator<LoginAuthenRequest>
    {
        public LoginModelValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Username is required");
            RuleFor(x => x.PassWord).NotEmpty().WithMessage("Password is required")
                .MinimumLength(6).WithMessage("Password at least 6 character");

        }
    }
}
