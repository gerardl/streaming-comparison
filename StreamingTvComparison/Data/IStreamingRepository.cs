using StreamingTvComparison.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreamingTvComparison.Data
{
    public interface IStreamingRepository
    {
        Task<List<Channel>> GetChannels();
        Task<List<Provider>> GetProviders();
    }
}
