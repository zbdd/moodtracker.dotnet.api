using restapinet.Domain.Models;

namespace restapinet.Domain.Repositories;

public interface IMoodEntryRepository
{
    Task<IEnumerable<MoodEntry>> ListAsync();
}