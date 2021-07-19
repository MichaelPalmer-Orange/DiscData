using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscController : ControllerBase
    {
        private readonly ILogger<DiscController> _logger;

        public DiscController(ILogger<DiscController> logger )
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

    }
}
