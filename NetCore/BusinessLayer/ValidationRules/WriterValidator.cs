using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar isim kısmı boş geçilemez");
            RuleFor(x=>x.WriterMail).NotEmpty().WithMessage("Yazar mail adresi boş geçilemez");
            RuleFor(x=>x.WriterPassword).NotEmpty().WithMessage("Şifre kısmı boş geçilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Minimum 2 karakter giriniz");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Maximum  50 karakter giriniz");

        }
    }
}
