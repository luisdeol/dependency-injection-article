using System;

namespace InjecaoDependenciaArtigo.API.Models
{
    public class EmailConfiguration
    {
        public EmailConfiguration()
        {
            From = "default@mail.com";
            Subject = "Default Subject";
        }

        public string From { get; set; }
        public string Subject { get; set; }

        public void Print() {
            Console.WriteLine($"From: {From}, Subject: {Subject}");
        }
    }
}