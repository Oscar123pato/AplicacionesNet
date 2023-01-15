using Microsoft.EntityFrameworkCore;
using WebApplicationAPI.Entities;

namespace WebApplicationAPI.Interfaces
{
    public interface IAppDbContext
    {
        DbSet<Categorias> Categorias { get; set; }
        DbSet<Post> Post { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}