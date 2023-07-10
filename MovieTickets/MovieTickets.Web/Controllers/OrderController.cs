using GemBox.Document;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieTickets.Service.Interfaces;
using System.IO;
using System;
using System.Text;
using MovieTickets.Domain.Domain;

namespace MovieTickets.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
        }

        [Authorize]
        public IActionResult Index()
        {
            return View(orderService.getAllOrders());
        }

        public FileContentResult generateInvoice(Guid id)
        {
            Order order = orderService.getOrderDetails(id);
            string path = Path.Combine(Directory.GetCurrentDirectory(), "invoice.docx");
            var document = DocumentModel.Load(path);
            document.Content.Replace("{{OrderNumber}}", order.Id.ToString());
            document.Content.Replace("{{UserDetails}}", order.Owner.UserName);
            StringBuilder builder = new StringBuilder();
            var total = 0.0;
            foreach (var item in order.TicketsInOrders)
            {
                builder.Append(item.MovieTicket.Movie.MovieName + ", Price: $" + item.MovieTicket.TicketPrice + ", Quantity: " + item.quantity + "\n");
                total += item.MovieTicket.TicketPrice * item.quantity;
            }
            document.Content.Replace("{{Tickets}}", builder.ToString());
            document.Content.Replace("{{Total}}", "$"+total.ToString());
            MemoryStream stream = new MemoryStream();
            document.Save(stream, new PdfSaveOptions());
            return File(stream.ToArray(), new PdfSaveOptions().ContentType, "Invoice.pdf");
        }
    }
}
