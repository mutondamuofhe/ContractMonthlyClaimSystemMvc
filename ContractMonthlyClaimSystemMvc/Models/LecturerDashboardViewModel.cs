using System;
using System.Collections.Generic;

namespace ContractMonthlyClaimSystem.Models
{
    public class LecturerDashboardViewModel
    {
        public string Email { get; set; }
        public int Total { get; set; }
        public int Pending { get; set; }
        public int Approved { get; set; }
        public List<ClaimViewModel> Recent { get; set; }
    }

    public class ClaimViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime DateSubmitted { get; set; }
    }
}
