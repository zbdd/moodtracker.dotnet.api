using Microsoft.EntityFrameworkCore;
using restapinet.Domain.Models;
using restapinet.Domain.Repositories;
using restapinet.Persistence.Contexts;
using restapinet.Domain.Models;

namespace restapinet.Persistence.Repositories;

public class MoodEntryRepository: BaseRepository, IMoodEntryRepository
{
    public MoodEntryRepository(AppDbContext context): base(context){}

    public async Task<IEnumerable<MoodEntry>> ListAsync()
    {
        return await _context.MoodEntries.ToListAsync();
    }
}