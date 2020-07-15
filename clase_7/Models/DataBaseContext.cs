using Microsoft.EntityFrameworkCore;

namespace clase_7.Models
{
  public class DataBaseContext : DbContext
  {
      public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
      {

      }
      public DbSet<Item> Items { get; set; }
  }
}
