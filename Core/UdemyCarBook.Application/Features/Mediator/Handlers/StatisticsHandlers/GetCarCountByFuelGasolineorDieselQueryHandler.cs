using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using UdemyCarBook.Application.Features.Mediator.Results.StatisticsResult;
using UdemyCarBook.Application.Interfaces.StatisticsInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetCarCountByFuelGasolineorDieselQueryHandler : IRequestHandler<GetCarCountByFuelGasolineorDieselQuery, GetCarCountByFuelGasolineorDieselQueryResult>
    {
        private readonly IStatisticsRepoository _repository;

        public GetCarCountByFuelGasolineorDieselQueryHandler(IStatisticsRepoository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarCountByFuelGasolineorDieselQueryResult> Handle(GetCarCountByFuelGasolineorDieselQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCountByFuelGasolineorDiesel();
            return new GetCarCountByFuelGasolineorDieselQueryResult
            {
                CarCountByFuelGasolineorDiesel = value,
            };
        }
    }
}
