using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace Project.Models.Validators
{

    //İsmin pek önemi yoktur, ancak genellikle doğrulama sınıflarının sonuna "Validator" eklenir.
    //Ayrıca , bu sınıfın FluentValidation kütüphanesinden AbstractValidator<T> sınıfından türemesi gerekir.
    //Çünkü AbstractValidator hangi sınıfın baz alınacağını ifade eder.
    public class DataValidator : AbstractValidator<Data>
    {

        //Base kullanılır çünkü biz abstract validator sınıfından türediğimiz için base ile constructorını çağırdığımızda problem çözülür.
        public DataValidator() : base()
        {
            RuleFor(all => all.Id)
              .GreaterThan(0).WithMessage("Id 0'dan büyük olmalıdır.")
              .NotEmpty().WithMessage("Id boş bırakılamaz.");
            RuleFor(all => all.Username)
                .NotEmpty().WithMessage("Kullanıcı adı boş bırakılamaz.")
                .MaximumLength(20).WithMessage("Kullanıcı adı en fazla 20 karakter olabilir.")
                .MinimumLength(5).WithMessage("Kullanıcı adı en az 5 karakter olabilir.");
            RuleFor(all => all.Email)
                .NotEmpty().WithMessage("Email boş bırakılamaz.")
                .EmailAddress().WithMessage("Geçerli bir email adresi giriniz.");
            RuleFor(all => all.Password)
                .NotEmpty().WithMessage("Parola boş bırakılamaz.")
                .MinimumLength(4).WithMessage("Parola en az 4 karakter olabilir.")
                .MaximumLength(15).WithMessage("Parola en fazla 15 karakter olabilir.");
                


        }
    }
}
