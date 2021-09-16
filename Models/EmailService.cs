namespace InjecaoDependenciaArtigo.API.Models
{
    public class EmailService
    {
        private readonly EmailConfiguration _configuration;
        public EmailService(EmailConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Send() {
            _configuration.Print();
        }
    }
}