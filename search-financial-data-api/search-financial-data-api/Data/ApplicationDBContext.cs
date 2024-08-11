using Microsoft.EntityFrameworkCore;
using search_financial_data_api.Models;

namespace search_financial_data_api.Data;

public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions dbContextOptions)
        : base(dbContextOptions)
    {

    }

    public DbSet<Stock> Stocks { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Portfolio> Portfolios { get; set; }
}