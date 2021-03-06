using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Channels;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChannelsController : ControllerBase
    {
        private IMediator _mediator;

        public ChannelsController(IMediator mediator) 
        {
           _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet]
        public async Task<ActionResult<List<Channel>>> List(CancellationToken cancellationToken) 
        {
            return await _mediator.Send(new List.Query(), cancellationToken);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Channel>> Details(Guid id)
        {
            return await _mediator.Send(new Details.Query { Id = id }); 
        }

        [HttpPost]
        public async Task<Unit> Create([FromBody] Create.Command command)
        {
            return await _mediator.Send(command);
        }
    }
}