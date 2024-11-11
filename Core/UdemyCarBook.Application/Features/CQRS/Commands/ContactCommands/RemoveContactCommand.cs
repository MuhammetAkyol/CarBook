using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.CQRS.Commands.ContactCommands
{
	public class RemoveContactCommand
	{
		public RemoveContactCommand(int id)
		{
			Id = id;
		}

		public int Id { get; set; }
    }
}
