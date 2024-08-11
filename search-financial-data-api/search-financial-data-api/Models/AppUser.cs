namespace search_financial_data_api.Models;

public class AppUser // : IdentityUser
{
    public List<Portfolio> Portfolios { get; set; } = new List<Portfolio>();
}