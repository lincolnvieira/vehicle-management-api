using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Application.Commands.Responses;

namespace Application.Commands.Requests
{
    public class AddVehicleRequest : IRequest
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Year { get; set; }
    }
}
