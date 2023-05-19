using DtoLayer.Dtos.AppUserDtos;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class CreateAppUserValidator : AbstractValidator<CreateAppUserDto>
    {
        public CreateAppUserValidator()
        {
            RuleFor(c => c.FirstName).NotEmpty().WithMessage("İsim alanı boş geçilemez");
            RuleFor(c => c.LastName).NotEmpty().WithMessage("Soyad alanı boş geçilemez");

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Email boş geçilemez")
                .EmailAddress().WithMessage("Lütfen geçerli bir email adresi giriniz");

            RuleFor(request => request.Password)
                .NotEmpty().WithMessage("Şifre alanı boş geçilemez")
                .MinimumLength(6).WithMessage("Şifre en az 6 karakterli olmalıdır")
                .Matches("[A-Z]").WithMessage("Şifre en az 1 tane büyük harf içermelidir")
                .Matches("[a-z]").WithMessage("Şifre en az 1 tane küçük harf içermelidir")
                .Matches(@"\d").WithMessage("Şifre en az 1 tane rakam içermelidir")
                .Matches(@"[][""!@$%^&*(){}:;<>,.?/+_=|'~\\-]").WithMessage("Şifre en az 1 tane özel karakter içermelidir");

            RuleFor(c => c.ConfirmPassword)
                .NotEmpty().WithMessage("Şifre tekrarı boş geçilemez")
                .Equal(x => x.Password).WithMessage("Şifreler uyuşmuyor");


        }
    }
}
