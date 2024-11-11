using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.Mediator.Commands.Featurecommands
{
	public class UpdateFeatureCommand : IRequest
	{
		public int FeatureID { get; set; }
		public string Name { get; set; }
	}
}
