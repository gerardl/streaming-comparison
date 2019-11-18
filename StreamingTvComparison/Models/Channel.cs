using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StreamingTvComparison.Models
{
    public class Channel
    {
        public int ChannelId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
