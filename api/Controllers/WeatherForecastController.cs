using System;
using System.Collections.Generic;
using System.Linq;
using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
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
            _logger.LogInfo("Here is info message from the controller.");
            _logger.LogDebug("Here is debug message from the controller.");
            _logger.LogWarn("Here is warn message from the controller.");
            _logger.LogError("Here is error message from the controller.");
            return new string[] { "value1", "value2" };
        }


        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
    }
}
