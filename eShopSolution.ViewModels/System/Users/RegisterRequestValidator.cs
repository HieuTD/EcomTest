using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.System.Users
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Họ không được để trống")
                .MaximumLength(200).WithMessage("Họ không được vượt quá 200 kí tự");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Tên không được để trống")
                .MaximumLength(200).WithMessage("Tên không được vượt quá 200 kí tự");

            RuleFor(x => x.Dob).GreaterThan(DateTime.Now.AddYears(-100)).WithMessage("Ngày sinh không thể lớn hơn 100 năm");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Email không được để trống")
                .Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")
                .WithMessage("Định dạng email không đúng");

            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Số điện thoại không được để trống");

            RuleFor(x => x.UserName).NotEmpty().WithMessage("Tên đăng nhập không được để trống");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Mật khẩu không được để trống")
                .MinimumLength(6).WithMessage("Mật khẩu phải có độ dài tối thiểu là 6");

            RuleFor(x => x).Custom((request, context) =>
            {
                if (request.Password != request.ConfirmPassword)
                {
                    context.AddFailure("Mật khẩu xác nhận không khớp");
                }
            });
        }
    }
}
