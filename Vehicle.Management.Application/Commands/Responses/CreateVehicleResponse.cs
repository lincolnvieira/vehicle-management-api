﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Management.Application.Commands.Responses
{
    public class CreateVehicleResponse
    {
        public Guid VehicleId { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
