using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class HairSalonContext : DbContext
  {
    public DbSet<PrimaryModel> PrimaryModel { get; set; }
    public DbSet<SecondaryModel> SecondaryModel { get; set; }

    public HairSalonContext(DbContextOptions options) : base(options) { }
  }
}

// Rename all [ Project Names ]; Rename Primary and Secondary Models with whatever model names you need. You may not need both, so use your best judgement.
// You only need this file if you're working with a database.