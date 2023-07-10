using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MovieTickets.Service.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MovieTickets.Service
{
    public class EmailScopedHostedService : IHostedService
    {

        private readonly IServiceProvider _serviceProvider;

        public EmailScopedHostedService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            await DoWork();
        }

        private async Task DoWork()
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var scopedProcessingService = scope.ServiceProvider.GetRequiredService<IBackgroundWorker>();
                await scopedProcessingService.DoWork();
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
