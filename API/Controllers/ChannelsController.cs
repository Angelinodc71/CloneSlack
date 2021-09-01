using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        private DataContext _context;
        private ILogger<ChannelsController> _logger;

        public ChannelsController (DataContext context, ILogger<ChannelsController> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IActionResult> Get()
        {
            Task<IEnumerable<Domain.Channel>> channelTask =  GetChannels();
            
            _logger.LogInformation("Task 1 finished");

            var channels = await channelTask;

            _logger.LogInformation("Task 2 finished");

            return Ok(channels);
        }

        private async Task<IEnumerable<Domain.Channel>> GetChannels()
        {
            var channels = await _context.Channels.ToListAsync();

            await Task.Delay(20000);

            return channels;
        }
        
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var channel = _context.Channels.FirstOrDefault(x => x.Id == id);
            
            return Ok(channel);
        }
    }
}