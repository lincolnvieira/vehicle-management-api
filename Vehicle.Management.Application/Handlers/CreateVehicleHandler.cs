using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Management.Application.Commands.Requests;
using Vehicle.Management.Application.Commands.Responses;

namespace Vehicle.Management.Application.Handlers
{
    public class CreateVehicleHandler : IRequestHandler<CreateVehicleRequest, CreateVehicleResponse>
    {
        public Task<CreateVehicleResponse> Handle(CreateVehicleRequest request, CancellationToken cancellationToken)
        {
            var result = new CreateVehicleResponse
            {
                VehicleId = Guid.NewGuid(),
                Name = "Ká",
                CreationDate = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}
