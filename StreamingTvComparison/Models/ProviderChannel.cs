using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StreamingTvComparison.Models
{
    public class ProviderChannel
    {
        public int ProviderId { get; set; }
        public Provider Provider { get; set; }
        public int ChannelId { get; set; }
        public Channel Channel { get; set; }
    }
}
