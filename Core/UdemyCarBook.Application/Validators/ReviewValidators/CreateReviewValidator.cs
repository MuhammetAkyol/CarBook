using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Commands.ReviewCommands;

namespace UdemyCarBook.Application.Validators.ReviewValidators
{
	public class CreateReviewValidator:AbstractValidator<CreateReviewCommand>
	{
        public CreateReviewValidator()
        {
            RuleFor(x => x.CustomerName).NotEmpty().WithMessage("Lütfen Müşteri Adını Boş Geçmeyiniz");
            RuleFor(x => x.CustomerName).MinimumLength(5).WithMessage("Lütfen En Az 5 Karakter Girişi Yapınız");
            RuleFor(x => x.RaytingValue).NotEmpty().WithMessage("Lütfen Puan Değerini Boş Geçmeyiniz");
            RuleFor(x => x.Comment).NotEmpty().WithMessage("Lütfen Yorum Değerini Boş Geçmeyiniz");
			RuleFor(x => x.Comment).MinimumLength(50).WithMessage("Lütfen Yorum Kısmına En Az 50 Karakter Girişi Yapınız");
			RuleFor(x => x.Comment).MaximumLength(500).WithMessage("Lütfen Yorum Kısmına En fazla 500 Karakter Girişi Yapınız");

		}
	}
}
