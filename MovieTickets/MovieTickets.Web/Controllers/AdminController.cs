using ExcelDataReader;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MovieTickets.Domain.Domain;
using MovieTickets.Domain.DTO;
using MovieTickets.Domain.Identity;
using MovieTickets.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Claims;

namespace MovieTickets.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly IUserService userService;
        private readonly UserManager<MovieTicketsApplicationUser> _userManager;

        public AdminController(IUserService userService, UserManager<MovieTicketsApplicationUser> userManager)
        {
            this.userService = userService;
            _userManager = userManager;
        }

        public IActionResult Index(string error)
        {
            if (error != null)
            {
                ViewBag.error = error;
            }
            return View(userService.getAllUsers());
        }

        public IActionResult SetRole(string email)
        {
            var user = userService.getUserByEmail(email);
            if (user == null)
            {
                return RedirectToAction("Index");
            }
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (user.Id == userId)
            {
                return RedirectToAction("Index", new { error = "You cannot demote yourself!!!" });
            }
            AddToRoleDto model = userService.getAddToRoleDto(user);
            return View(model);
        }

        [HttpPost]
        public IActionResult SetRole(AddToRoleDto model)
        {
            if (ModelState.IsValid)
            {
                userService.addToRoleUser(model.Email, model.SelectedRole);
                return RedirectToAction("Index");
            }
            model.SelectedRole = null;
            model.Roles = new List<string>() { "Admin", "StandardUser" };
            return View(model);
        }

        public IActionResult importUsers()
        {
            return View();
        }

        [HttpPost]
        public IActionResult importUsers(IFormFile file)
        {
            string path = $"{Directory.GetCurrentDirectory()}\\files\\{file.FileName}";
            using (var fileStream = System.IO.File.Create(path))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }
            List<UserImportDto> users = getUsers(file.FileName);
            register(users);
            return RedirectToAction("Index");
        }

        private List<UserImportDto> getUsers(string name)
        {
            List<UserImportDto> users = new List<UserImportDto>();
            String filePath = $"{Directory.GetCurrentDirectory()}\\files\\{name}";
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using (var stream = System.IO.File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    while (reader.Read())
                    {
                        users.Add(new UserImportDto
                        {
                            FirstName = reader.GetValue(0).ToString(),
                            LastName = reader.GetValue(1).ToString(),
                            Email = reader.GetValue(2).ToString(),
                            Address = reader.GetValue(3).ToString(),
                            Password = reader.GetValue(4).ToString(),
                            RepeatPassword = reader.GetValue(5).ToString(),
                            PhoneNumber = reader.GetValue(6).ToString(),
                            Role = reader.GetValue(7).ToString()
                        });
                    }
                }
            }
            return users;
        }

        private bool register(List<UserImportDto> users)
        {
            bool status = true;
            foreach (var u in users)
            {
                var res = _userManager.FindByEmailAsync(u.Email).Result;
                if (res == null)
                {
                    var user = new MovieTicketsApplicationUser
                    {
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        Address = u.Address,
                        UserName = u.Email,
                        NormalizedUserName = u.Email,
                        Email = u.Email,
                        PhoneNumber = u.PhoneNumber,
                        EmailConfirmed = true,
                        PhoneNumberConfirmed = true,
                        UserCart = new ShoppingCart()
                    };
                    var r = _userManager.CreateAsync(user, u.Password).Result;
                    var _ = _userManager.AddToRoleAsync(user, u.Role).Result;
                    status = status && r.Succeeded;
                }
            }

            return status;
        }
    }
}
