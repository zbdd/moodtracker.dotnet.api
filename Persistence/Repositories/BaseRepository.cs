using restapinet.Persistence.Contexts;

namespace restapinet.Persistence.Repositories;

public abstract class BaseRepository
{
    protected readonly AppDbContext _context;

    public BaseRepository(AppDbContext context)
    {
        _context = context;
    }
}