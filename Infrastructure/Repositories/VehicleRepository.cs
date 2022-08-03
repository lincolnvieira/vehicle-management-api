using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Infrastructure.Database;
using Domain.Models;
using Domain.Consts;

namespace Infrastructure.Repositories
{
    public class VehicleRepository
    { 

        public VehicleRepository( )
        {

        }

        public void AddVehicle(Vehicle vehicle)
        {
            List<Vehicle> vehicles = DatabaseConfiguration.GetAllData<Vehicle>(DatabasePathConst.VehiclePath)?.ToList() ?? new List<Vehicle>();

            vehicles.Add(vehicle);
             
            DatabaseConfiguration.InsertAllData(vehicles, DatabasePathConst.VehiclePath);
        }
    }
}
