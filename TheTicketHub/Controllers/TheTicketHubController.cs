using Azure.Storage.Queues;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Runtime.InteropServices.Marshalling;
using System.Text.Json;

namespace TheTicketHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheTicketHubController : ControllerBase
    {
        private readonly ILogger<TheTicketHubController> _logger;
        private readonly IConfiguration _configuration;
        public TheTicketHubController(ILogger<TheTicketHubController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok("Hello from Contacts API - Get()");
        }

        [HttpPost]

        public async Task<IActionResult> Post(TheTicketHub theTicketHub)
        {

            //1.Validation

            if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }
            
            // 2. Send ticket information to Azure queue

            string queueName = "thetickethub";

            // Get connection string from secrets.json
            string? connectionString = _configuration["AzureStorageConnectionString"];

            if (string.IsNullOrEmpty(connectionString))
            {
                return BadRequest("An error was encountered");
            }

            QueueClient queueClient = new QueueClient(connectionString, queueName);

            // serialize an object to json
            string message = JsonSerializer.Serialize(theTicketHub);

            // send string message to queue
            await queueClient.SendMessageAsync(message);

            return Ok("Hello " + theTicketHub.name + ". The ticket information added to Azure queue.");
        }
    }
}
