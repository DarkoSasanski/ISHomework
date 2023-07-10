using System.Threading.Tasks;

namespace MovieTickets.Service.Interfaces
{
    public interface IBackgroundWorker
    {
        Task DoWork();
    }
}
