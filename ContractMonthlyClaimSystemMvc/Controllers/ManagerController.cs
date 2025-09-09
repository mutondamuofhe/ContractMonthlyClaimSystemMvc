using Microsoft.AspNetCore.Mvc;
using ContractMonthlyClaimSystem.Models;

namespace ContractMonthlyClaimSystem.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult Dashboard()
        {
            var model = new DashboardViewModel
            {
                Pending = 5,   // Replace with DB logic
                Approved = 10, // Replace with DB logic
                Rejected = 2   // Replace with DB logic
            };

            return View(model);
        }
    }
}
