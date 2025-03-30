using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
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
        //public async Task<IActionResult> Post(Ticket_Hub contact)
        public IActionResult Post(TheTicketHub theTicketHub)
        {
            
            //1.Validation
            if (string.IsNullOrEmpty(theTicketHub.Name) || string.IsNullOrEmpty(theTicketHub.Phone))
            {
                return BadRequest("Name and Phone are required");
            }
            
            return Ok("Hello" + theTicketHub.Name + " from Post()");



            //if (ModelState.IsValid == false)
            //{
            //    return BadRequest(ModelState);
            //}

            //// 2. Send contact to Azure queue

            //string queueName = "ticket-hub";

            //// Get connection string from secrets.json
            //string? connectionString = _configuration["AzureStorageConnectionString"];

            //if (string.IsNullOrEmpty(connectionString))
            //{
            //    return BadRequest("An error was encountered");
            //}

            //QueueClient queueClient = new QueueClient(connectionString, queueName);

            //// serialize an object to json
            //string message = JsonSerializer.Serialize(contact);
            ////string message = "Hello from API.";

            //// send string message to queue
            //await queueClient.SendMessageAsync(message);

            //return Ok("Hello " + contact.Name + ". Contact added to Azure queue.");
        }
    }
}
