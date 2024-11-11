using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Queries.AboutQueries;
using UdemyCarBook.Application.Features.CQRS.Results.AboutResults;
using UdemyCarBook.Application.Features.Mediator.Results.LocationResults;

namespace UdemyCarBook.Application.Features.Mediator.Queries.LocationQueries
{
	public class GetLocationByIdQuery:IRequest<GetLocationByIdQueryResult>
	{
		public GetLocationByIdQuery(int id)
		{
			Id = id;
		}

		public int Id { get; set; }
    }
}
