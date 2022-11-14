﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty()
                .WithMessage("Kategori ismini boş geçemezsiniz.");
            RuleFor(x => x.CategoryDescription).NotEmpty()
              .WithMessage("Kategori açıklamasını boş geçemezsiniz.");
            RuleFor(x => x.CategoryName).MaximumLength(50)
              .WithMessage("Kategori adı en fazla 50 karakter olmalıdır.");
            RuleFor(x => x.CategoryName).MinimumLength(5)
           .WithMessage("Kategori adı en az 3 karakter olmalıdır.");
        }
    }
}
