using System.Collections.Generic;
using System.Threading.Tasks;
using restapinet.Domain.Models;

namespace restapinet.Domain.Services
{
    public interface IMoodEntryService
    {
        Task<IEnumerable<MoodEntry>> ListAsync();
    }
}