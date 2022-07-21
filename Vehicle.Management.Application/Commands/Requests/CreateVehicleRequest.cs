using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Vehicle.Management.Application.Commands.Responses;

namespace Vehicle.Management.Application.Commands.Requests
{
    public class CreateVehicleRequest : IRequest<CreateVehicleResponse>
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Year { get; set; }
    }
}
