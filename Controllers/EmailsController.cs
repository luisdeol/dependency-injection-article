using InjecaoDependenciaArtigo.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace InjecaoDependenciaArtigo.API.Controllers
{
    [Route("api/[controller]")]
    public class EmailsController : ControllerBase
    {
        private readonly EmailConfiguration _configuration;
        private readonly EmailService _emailService;
        public EmailsController(EmailConfiguration configuration, EmailService emailService)
        {
            _configuration = configuration;
            _emailService = emailService;

            _configuration.Print();
        }

        [HttpGet]
        public IActionResult Get(){
            _configuration.From = "luisdev@email.com";
            _configuration.Subject = "Welcome!";

            _emailService.Send();

            return Ok(_configuration);
        }
    }
}