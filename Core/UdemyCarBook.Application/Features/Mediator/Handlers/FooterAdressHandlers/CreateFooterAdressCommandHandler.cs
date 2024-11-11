using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Commands.AboutCommands;
using UdemyCarBook.Application.Features.Mediator.Commands.Featurecommands;
using UdemyCarBook.Application.Features.Mediator.Commands.FooterAdressCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.FooterAdressHandlers
{
	public class CreateFooterAdressCommandHandler : IRequestHandler<CreateFooterAdressCommand>
	{
		private readonly IRepository<FooterAdress> _repository;

		public CreateFooterAdressCommandHandler(IRepository<FooterAdress> repository)
		{
			_repository = repository;
		}

		public async Task Handle(CreateFooterAdressCommand request, CancellationToken cancellationToken)
		{
			await _repository.CreateAsync(new FooterAdress
			{
				Address = request.Address,
				Description = request.Description,
				Email = request.Email,
				Phone = request.Phone
			});
		}
	}
}
