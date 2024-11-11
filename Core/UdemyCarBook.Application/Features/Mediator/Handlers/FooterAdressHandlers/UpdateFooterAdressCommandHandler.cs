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
	public class UpdateFooterAdressCommandHandler : IRequestHandler<UpdateFooterAdressCommand>
	{
		private readonly IRepository<FooterAdress> _repository;

		public UpdateFooterAdressCommandHandler(IRepository<FooterAdress> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateFooterAdressCommand request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.FooterAdressID);
			values.Phone=request.Phone;
			values.Address=request.Address;
			values.Description=request.Description;
			values.Email=request.Email;
			await _repository.UpdateAsync(values);
		}
	}
}
