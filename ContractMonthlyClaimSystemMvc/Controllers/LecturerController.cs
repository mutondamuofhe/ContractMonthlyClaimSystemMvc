using Microsoft.AspNetCore.Mvc;
using ContractMonthlyClaimSystem.Models;
using System;
using System.Collections.Generic;

namespace ContractMonthlyClaimSystem.Controllers
{
    public class LecturerController : Controller
    {
        public IActionResult Dashboard()
        {
            var model = new LecturerDashboardViewModel
            {
                Email = "lecturer@example.com",
                Total = 12,
                Pending = 3,
                Approved = 7,
                Recent = new List<ClaimViewModel>
                {
                    new ClaimViewModel { Title="Claim 1", Description="Extra classes", Status="Pending", DateSubmitted=DateTime.Now.AddDays(-2) },
                    new ClaimViewModel { Title="Claim 2", Description="Exam invigilation", Status="Approved", DateSubmitted=DateTime.Now.AddDays(-5) }
                }
            };

            return View(model);
        }
    }
}
