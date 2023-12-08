using Microsoft.AspNetCore.Mvc;
using vendasAPI.Model;
using vendasAPI.Services.Implementations;

namespace vendasAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {
        private readonly ILogger<ClienteController> _logger;
        private IClienteService _clienteService;

        public ClienteController(ILogger<ClienteController> logger, IClienteService clienteService)
        {
            _logger= logger;
            _clienteService = clienteService;
        }
        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_clienteService.FindAll());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_clienteService.FindAll());
        }
        [HttpPost]
        public IActionResult Put([FromBody] Cliente cliente)
        {
            if (cliente == null)
            {
                return BadRequest();
            }

            return Ok(_clienteService.Update(cliente));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _clienteService.Delete(id);
            return NoContent();
        }


    }
}
