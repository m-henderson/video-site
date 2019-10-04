using Microsoft.EntityFrameworkCore;

namespace video_site.Persistence
{
    public class ApplcaitionDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=videosite;Username=my_user;Password=my_pw");
    }
}