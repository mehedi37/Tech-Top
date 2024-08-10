using Microsoft.EntityFrameworkCore;

namespace Tech_Top.Models
{
    public class TechContext(DbContextOptions<TechContext> options) : DbContext(options)
    {
        public DbSet<TechModel> TechModels { get; set; }
    }
}
