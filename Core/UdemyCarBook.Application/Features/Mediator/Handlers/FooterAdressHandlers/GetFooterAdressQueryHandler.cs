using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Queries.FooterAdressQueries;
using UdemyCarBook.Application.Features.Mediator.Results.FooterAdressResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.FooterAdressHandlers
{
	public class GetFooterAdressQueryHandler : IRequestHandler<GetFooterAdressQuery, List<GetFooterAdressQueryResult>>
	{
		private readonly IRepository<FooterAdress> _repository;

		public GetFooterAdressQueryHandler(IRepository<FooterAdress> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetFooterAdressQueryResult>> Handle(GetFooterAdressQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetAllAsync();
			return values.Select(x => new GetFooterAdressQueryResult
			{
				Address = x.Address,
				Description = x.Description,
				Email = x.Email,
				FooterAdressID = x.FooterAdressID,
				Phone=x.Phone
			}).ToList();
		}
	}
}
