

namespace MovieTickets.Domain
{
    public class EmailSettings
    {
        public string SmtpServer { get; set; }
        public string SmtpUserName { get; set; }
        public string SmtpPassword { get; set; }
        public int SmtpServerPort { get; set; }
        public bool UseSsl { get; set; }
        public string SenderName { get; set; }
        public string SmtpDisplayName { get; set; }
    }
}
