using Microsoft.AspNetCore.Mvc;
using ContractMonthlyClaimSystemMvc.Models;

namespace ContractMonthlyClaimSystemMvc.Controllers
{
    public class ClaimsController : Controller
    {
        // get: /Claims/Create
        public IActionResult Create()
        {
            return View();
        }

        // post: /Claims/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Claim model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // todo: Save the claim to your database or in-memory list

            TempData["Success"] = "Claim submitted successfully.";
            return RedirectToAction("Track");
        }

        // get: /Claims/Track
        public IActionResult Track()
        {
            // todo: return real claims (from DB or service)
            return View();
        }
    }
}
