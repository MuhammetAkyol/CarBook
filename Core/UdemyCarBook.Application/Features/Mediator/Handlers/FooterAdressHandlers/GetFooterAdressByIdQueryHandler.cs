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
	public class GetFooterAdressByIdQueryHandler : IRequestHandler<GetFooterAdressByIdQuery, GetFooterAdressByIdQueryResult>
	{
		private readonly IRepository<FooterAdress> _repository;

		public GetFooterAdressByIdQueryHandler(IRepository<FooterAdress> repository)
		{
			_repository = repository;
		}

		public async Task<GetFooterAdressByIdQueryResult> Handle(GetFooterAdressByIdQuery request, CancellationToken cancellationToken)
		{
			var value= await _repository.GetByIdAsync(request.Id);
			return new GetFooterAdressByIdQueryResult
			{
				Address = value.Address,
				Description = value.Description,
				Email = value.Email,
				FooterAdressID=value.FooterAdressID,
				Phone = value.Phone
			};
		}
	}
}
