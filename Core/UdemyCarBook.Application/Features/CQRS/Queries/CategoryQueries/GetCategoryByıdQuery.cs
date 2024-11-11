using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.CQRS.Queries.CategoryQueries
{
	public class GetCategoryByıdQuery
	{
		public GetCategoryByıdQuery(int id)
		{
			Id = id;
		}

		public int Id { get; set; }
    }
}
