namespace ContractMonthlyClaimSystem.Models
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // e.g. "Lecturer" or "Manager" or "program coodinator"
    }
}
