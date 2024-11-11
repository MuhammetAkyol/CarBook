using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Commands.FooterAdressCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.FooterAdressHandlers
{
	public class RemoveFooterAdressCommandHandler : IRequestHandler<RemoveFooterAdressCommand>
	{
		private readonly IRepository<FooterAdress> _repository;

		public RemoveFooterAdressCommandHandler(IRepository<FooterAdress> repository)
		{
			_repository = repository;
		}

		public async Task Handle(RemoveFooterAdressCommand request, CancellationToken cancellationToken)
		{
			var value= await _repository.GetByIdAsync(request.Id);
			await _repository.RemoveAsync(value);
		}
	}
}
