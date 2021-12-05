using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;

// DI, Serilog, Settings

namespace GobiMax
{
    public class GreetingService : IGreetingService
    {
        private readonly ILogger<GreetingService> _log;
        private readonly IConfiguration _config;

        public GreetingService(ILogger<GreetingService> log, IConfiguration config)
        {
            _log = log;
            _config = config;
        }
        public void Run()
        {
            //_log.LogInformation("Starting Game");
            Console.WriteLine("Welcome to GobiMax");
        }
    }
}
