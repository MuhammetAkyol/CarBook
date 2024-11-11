using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands.Featurecommands;
using UdemyCarBook.Application.Features.Mediator.Queries.FeatureQueries;

namespace UdemyCarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FeaturesController : ControllerBase
	{
		private readonly IMediator _mediator;

		public FeaturesController(IMediator mediator)
		{
			_mediator = mediator;
		}
		[HttpGet]
		public async Task<IActionResult> FeatureList()
		{
			var values = await _mediator.Send(new GetFeatureQuery());
			return Ok(values);
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetFeature(int id)
		{
			var value = await _mediator.Send(new GetFeatureByIdQuery(id));
			return Ok(value);
		}
		[HttpPost]
		public async Task<IActionResult> CreateFeature(CreateFeatureCommand command)
		{
			await _mediator.Send(command);
			return Ok("Özellik Başarı İle Eklendi");
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> RemoveFeature(int id)
		{
			await _mediator.Send(new RemoveFeatureCommand(id));
			return Ok("Özellik Başarı İle Silindi");
		}
		[HttpPut]
		public async Task<IActionResult> UpdateFeature(UpdateFeatureCommand command)
		{
			await _mediator.Send(command);
			return Ok("Özellik Başarı İle Güncellendi");
		}
	}
}
