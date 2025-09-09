using Microsoft.AspNetCore.Mvc;
using ContractMonthlyClaimSystemMvc.Models;

namespace ContractMonthlyClaimSystemMvc.Controllers
{
    public class ClaimsController : Controller
    {
        // GET: /Claims/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Claims/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Claim model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // TODO: Save the claim to your database or in-memory list

            TempData["Success"] = "Claim submitted successfully.";
            return RedirectToAction("Track");
        }

        // GET: /Claims/Track
        public IActionResult Track()
        {
            // TODO: return real claims (from DB or service)
            return View();
        }
    }
}
