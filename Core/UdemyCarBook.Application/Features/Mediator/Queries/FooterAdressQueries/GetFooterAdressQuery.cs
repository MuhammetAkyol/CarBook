using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Results.FooterAdressResults;

namespace UdemyCarBook.Application.Features.Mediator.Queries.FooterAdressQueries
{
	public class GetFooterAdressQuery:IRequest<List<GetFooterAdressQueryResult>>
	{
	}
}
