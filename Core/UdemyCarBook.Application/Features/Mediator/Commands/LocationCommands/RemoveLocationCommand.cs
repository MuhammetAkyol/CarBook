using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.Mediator.Commands.LocationCommands
{
	public class RemoveLocationCommand:IRequest
	{
		public RemoveLocationCommand(int id)
		{
			Id = id;
		}

		public int Id { get; set; }
    }
}
