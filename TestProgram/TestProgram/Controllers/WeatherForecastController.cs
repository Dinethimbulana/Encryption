using EncryptData.Encryption;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProgram.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string method()
        { 
            byte[] encrypt = EncryptionMiddleware.Encrypt("Pa$$w0rd.");
            string encryptValue = System.Text.Encoding.UTF8.GetString(encrypt);

            string decryptValue = EncryptionMiddleware.DecryptString("�K.̮�\u0013rH����\u0014C�");

            return decryptValue;
        }
    }
}
