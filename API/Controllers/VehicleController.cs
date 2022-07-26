﻿using Microsoft.AspNetCore.Http;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Commands.Requests;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IMediator _mediator;

        public VehicleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("AddVehicle")]
        public async Task<ActionResult> AddVehicle([FromBody] AddVehicleRequest request)
        {
            await _mediator.Send(request);

            return Ok();
        }
    }
}
