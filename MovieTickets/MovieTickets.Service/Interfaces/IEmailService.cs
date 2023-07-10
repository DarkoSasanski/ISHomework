using MovieTickets.Domain.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieTickets.Service.Interfaces
{
    public interface IEmailService
    {
        Task SendEmails(List<EmailMessage> messages);
    }
}
