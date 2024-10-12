using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;

namespace MultiShop.RabbitMqMessageApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateMessage()
        {
             var connectionFactory=new ConnectionFactory();
            {
                HostNa
            };
            var connection = connectionFactory.CreateConnection();
            return Ok("Mesajınız kuyruğa alınmıştır");
        }
    }
}
