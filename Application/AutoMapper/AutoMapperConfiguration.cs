using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Commands.Requests;
using AutoMapper;
using Domain.Models;

namespace Application.AutoMapper
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<AddVehicleRequest, Vehicle>();
        }
    }
}
