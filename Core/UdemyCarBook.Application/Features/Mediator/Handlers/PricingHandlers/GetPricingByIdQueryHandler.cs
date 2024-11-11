using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Queries.PricingQueries;
using UdemyCarBook.Application.Features.Mediator.Results.FeatureResults;
using UdemyCarBook.Application.Features.Mediator.Results.PricingResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.PricingHandlers
{
	public class GetPricingByIdQueryHandler : IRequestHandler<GetPricingByIdQuery, GetPricinByIdQueryResult>
	{
		private readonly IRepository<Pricing> _repository;

		public GetPricingByIdQueryHandler(IRepository<Pricing> repository)
		{
			_repository = repository;
		}

		public async Task<GetPricinByIdQueryResult> Handle(GetPricingByIdQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.Id);
			return new GetPricinByIdQueryResult
			{
				PricingID= values.PricingID,
				Name = values.Name
			};
		}
	}
}
