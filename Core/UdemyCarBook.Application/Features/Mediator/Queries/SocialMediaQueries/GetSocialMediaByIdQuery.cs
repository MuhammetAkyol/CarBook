using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Results.SocialMediaResults;

namespace UdemyCarBook.Application.Features.Mediator.Queries.SocialMediaQueries
{
	public class GetSocialMediaByIdQuery:IRequest<GetSocialMediaByIdQueryResult>
	{
		public GetSocialMediaByIdQuery(int id)
		{
			Id = id;
		}

		public int Id { get; set; }
    }
}
