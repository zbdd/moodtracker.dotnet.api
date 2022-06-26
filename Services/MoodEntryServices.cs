using System.Collections.Generic;
using System.Threading.Tasks;
using restapinet.Domain.Models;
using restapinet.Domain.Repositories;
using restapinet.Domain.Services;

namespace restapinet.Services
{
    public class MoodEntryService: IMoodEntryService
    {
        private readonly IMoodEntryRepository _moodEntryRepository;

        public MoodEntryService(IMoodEntryRepository moodEntryRepository)
        {
            _moodEntryRepository = moodEntryRepository;
        }
        public async Task<IEnumerable<MoodEntry>> ListAsync()
        {
            return await _moodEntryRepository.ListAsync();
        }
    }
}