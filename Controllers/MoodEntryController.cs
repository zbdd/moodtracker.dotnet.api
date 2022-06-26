using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Threading.Tasks;
using restapinet.Domain.Services;
using restapinet.Domain.Models;

namespace restapinet.Controllers
{
    [Route("/[controller]")]
    public class MoodEntryController: Controller 
    {
        private readonly IMoodEntryService moodEntryService;

        public MoodEntryController(IMoodEntryService moodEntryService)
        {
            this.moodEntryService = moodEntryService;
        }

        [HttpGet]
        public async Task<IEnumerable<MoodEntry>> GetAllAsync()
        {
            var moodEntries = await this.moodEntryService.ListAsync();
            return moodEntries;
        }
    }
}