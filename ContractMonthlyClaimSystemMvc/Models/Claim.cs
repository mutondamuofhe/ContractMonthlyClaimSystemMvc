namespace ContractMonthlyClaimSystemMvc.Models
{
    public class Claim
    {
        public int Id { get; set; }

        public string Title { get; set; } = "";

        public string Description { get; set; } = "";

        public decimal Amount { get; set; }
        public string SubmittedBy { get; internal set; }
        public object DateSubmitted { get; internal set; }
        public ClaimStatus Status { get; internal set; }
    }
}
