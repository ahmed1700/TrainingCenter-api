using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using LoggerServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TrainingCenter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILoggerManager _logger;
        public WeatherForecastController(ILoggerManager logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInfo("Log  LogInfo");
            _logger.LogDebug("Log  LogDebug");
            _logger.LogError("Log  LogError");
            _logger.LogWarn("Log LogWarn");

            return new string[] { "aaa" , "bbbb" };
        }
    }
}
