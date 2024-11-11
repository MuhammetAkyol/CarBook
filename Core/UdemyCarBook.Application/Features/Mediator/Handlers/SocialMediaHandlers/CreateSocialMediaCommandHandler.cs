using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Commands.SocialMediaCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.SocialMediaHandlers
{
	public class CreatePricingCommandHandler : IRequestHandler<CreateSocialMediaCommand>
	{
		private readonly IRepository<SocialMedia> _repository;

		public CreatePricingCommandHandler(IRepository<SocialMedia> repository)
		{
			_repository = repository;
		}

		public async Task Handle(CreateSocialMediaCommand request, CancellationToken cancellationToken)
		{
			await _repository.CreateAsync(new SocialMedia
			{
				Icon=request.Icon,
				Name=request.Name,
				Url=request.Url
			});
		}
	}
}
