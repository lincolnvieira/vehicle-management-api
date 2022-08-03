using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.Responses
{
    public class AddVehicleResponse
    {
        public Guid VehicleId { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
