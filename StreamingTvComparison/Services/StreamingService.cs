using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StreamingTvComparison.Data;
using StreamingTvComparison.Models;

namespace StreamingTvComparison.Services
{
    public class StreamingService : IStreamingService
    {
        private readonly IStreamingRepository _streamingRepository;

        public StreamingService(IStreamingRepository streamingRepository)
        {
            _streamingRepository = streamingRepository;
        }

        public async Task<List<Channel>> GetChannels()
        {
            return await _streamingRepository.GetChannels();
        }

        public async Task<List<Provider>> GetProviders()
        {
            return await _streamingRepository.GetProviders();
        }
    }
}
