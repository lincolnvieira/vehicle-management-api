using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Management.Application.Commands.Requests;
using Vehicle.Management.Application.Commands.Responses;
using Vehicle.Management.Infrastructure.Repositorys;

namespace Vehicle.Management.Application.Handlers
{
    public class AddVehicleHandler : IRequestHandler<AddVehicleRequest>
    {
        private readonly VehicleRepository _vehicleRepository;

        public AddVehicleHandler(VehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public Task<Unit> Handle(AddVehicleRequest request, CancellationToken cancellationToken)
        {

            return Task.FromResult(Unit.Value);
        }
    }
}
