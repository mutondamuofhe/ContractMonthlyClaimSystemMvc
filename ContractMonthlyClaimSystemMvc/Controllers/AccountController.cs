using Microsoft.AspNetCore.Mvc;
using ContractMonthlyClaimSystem.Models;
using System.Collections.Generic;

namespace ContractMonthlyClaimSystem.Controllers
{
    public class AccountController : Controller
    {
        // Mock "database" for now
        private static List<User> Users = new List<User>
        {
            new User { Email = "lecturer@example.com", Password = "12345", Role = "Lecturer" },
            new User { Email = "manager@example.com", Password = "12345", Role = "Manager" }
        };

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = Users.Find(u => u.Email == email && u.Password == password);
            if (user != null)
            {
                if (user.Role == "Lecturer")
                    return RedirectToAction("Dashboard", "Lecturer");
                else if (user.Role == "Manager")
                    return RedirectToAction("Dashboard", "Manager");
            }

            ViewBag.Error = "Invalid credentials!";
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string email, string password, string role)
        {
            Users.Add(new User { Email = email, Password = password, Role = role });

            // After register, go straight to login.
            return RedirectToAction("Login");
        }
    }
}
