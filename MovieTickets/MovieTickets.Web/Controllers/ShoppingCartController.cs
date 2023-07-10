using Microsoft.AspNetCore.Mvc;
using MovieTickets.Service.Interfaces;
using Stripe;
using System.Security.Claims;
using System;
using Microsoft.AspNetCore.Authorization;

namespace MovieTickets.Web.Controllers
{
    [Authorize]
    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCartService shoppingCartService;

        public ShoppingCartController(IShoppingCartService shoppingCartService)
        {
            this.shoppingCartService = shoppingCartService;
        }

        public IActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            return View(shoppingCartService.GetShoppingCartDto(userId));
        }

        private bool OrderNow()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!string.IsNullOrEmpty(userId))
            {
                return shoppingCartService.OrderNow(userId) != null;
            }
            return false;
        }

        public IActionResult RemoveFromCart(Guid? id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            shoppingCartService.deleteFromCart(userId, id);
            return RedirectToAction("Index", "ShoppingCart");
        }

        public IActionResult PayOrder(string StripeEmail, string StripeToken)
        {
            var customerService = new CustomerService();
            var chargeService = new ChargeService();
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var order = shoppingCartService.GetShoppingCartDto(userId);
            var customer = customerService.Create(new CustomerCreateOptions
            {
                Email = StripeEmail,
                Source = StripeToken
            });
            var charge = chargeService.Create(new ChargeCreateOptions
            {
                Amount = (long?)(order.TotalPrice * 100),
                Description = "Movie Tickets Application Payment",
                Currency = "usd",
                Customer = customer.Id,
            });
            if (charge.Status == "succeeded")
            {
                if (OrderNow())
                {
                    return RedirectToAction("Index", "MovieTickets");
                }
            }
            return RedirectToAction("Index", "MovieTickets");
        }
    }
}
