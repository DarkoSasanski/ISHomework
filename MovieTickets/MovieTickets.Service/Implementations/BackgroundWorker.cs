using MovieTickets.Domain.Domain;
using MovieTickets.Repository.Interfaces;
using MovieTickets.Service.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTickets.Service.Implementations
{
    public class BackgroundWorker : IBackgroundWorker
    {
        private readonly IEmailService emailService;
        private readonly IRepository<EmailMessage> emailRepository;

        public BackgroundWorker(IEmailService emailService, IRepository<EmailMessage> emailRepository)
        {
            this.emailService = emailService;
            this.emailRepository = emailRepository;
        }

        public async Task DoWork()
        {
            await emailService.SendEmails(emailRepository.GetAll().Where(z => !z.Status).ToList());
        }
    }
}
