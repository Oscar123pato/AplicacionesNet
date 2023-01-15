using Microsoft.EntityFrameworkCore;
using WebApplicationAPI.Entities;
using WebApplicationAPI.Interfaces;

namespace WebApplicationAPI.Context
{
    public class AppDbContext : DbContext, IAppDbContext
    {

        public DbSet<Post> Post { get; set; }
        public DbSet<Categorias> Categorias { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=WAZAAK;Initial Catalog=API;User ID=sa;Password=Xerox2019oscar; TrustServerCertificate=True");
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
