using CakeShop.Service.Users.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeShop.Service.Users.Service
{
    public class RegisterModelValidator : AbstractValidator<RegisterModel>
    {
        public RegisterModelValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Username is required");
            RuleFor(x => x.PassWord).NotEmpty().WithMessage("Password is required")
                .MinimumLength(6).WithMessage("Password at least 6 character");
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First name is required")
                .MaximumLength(100).WithMessage("First name can not over 100 character");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("First name is required")
                .MaximumLength(100).WithMessage("Last name can not over 100 character");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required")
                .MaximumLength(100).WithMessage("Email can not over 100 character");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Phone number is required")
                .MaximumLength(10).WithMessage("Phone number can not over 10 character");
            RuleFor(x => x.DateOfBirth).GreaterThan(DateTime.Now.AddYears(-100))
                .WithMessage("Date of birth can not over 100 years");
            RuleFor(x => x).Custom((request, context) =>
            {
                if (request.PassWord != request.ConfirmPassWord)
                {
                    context.AddFailure("Confirm password is incorrect");
                }
            });


        }
    }
}
