using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Commands.Featurecommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.FeatureHandlers
{
	public class RemoveFeatureCommanHandler : IRequestHandler<RemoveFeatureCommand>
	{
		private readonly IRepository<Feature> _repository;

		public RemoveFeatureCommanHandler(IRepository<Feature> repository)
		{
			_repository = repository;
		}

		public async Task Handle(RemoveFeatureCommand request, CancellationToken cancellationToken)
		{
			var value = await _repository.GetByIdAsync(request.Id);
			await _repository.RemoveAsync(value);
		}
	}
}
