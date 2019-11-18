using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StreamingTvComparison.Models;

namespace StreamingTvComparison.Data
{
    public class StreamingRepository : IStreamingRepository
    {
        private readonly ApplicationDbContext _context;

        public StreamingRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Channel>> GetChannels()
        {
            return await _context.Channel
                            .Where(w => w.IsActive)
                            .ToListAsync();
        }

        public async Task<List<Provider>> GetProviders()
        {
            return await _context.Provider
                            .Include(i => i.ProviderChannels)
                            .Where(w => w.IsActive)
                            .ToListAsync();
        }
    }
}
