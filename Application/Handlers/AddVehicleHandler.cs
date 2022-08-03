using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Commands.Requests;
using Application.Commands.Responses;
using Infrastructure.Repositories;
using AutoMapper;
using Domain.Models;

namespace Application.Handlers
{
    public class AddVehicleHandler : IRequestHandler<AddVehicleRequest, Unit>
    {
        private readonly IMapper _mapper;
        private readonly VehicleRepository _vehicleRepository;

        public AddVehicleHandler(VehicleRepository vehicleRepository, IMapper mapper)
        {
            _vehicleRepository = vehicleRepository;
            _mapper = mapper;
        }

        public Task<Unit> Handle(AddVehicleRequest request, CancellationToken cancellationToken)
        {
            Vehicle vehicle = _mapper.Map<Vehicle>(request);

            vehicle.VehicleId = Guid.NewGuid();

            _vehicleRepository.AddVehicle(vehicle);

            return Task.FromResult(Unit.Value);
        }
    }
}
