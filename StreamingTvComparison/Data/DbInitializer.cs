using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreamingTvComparison.Data
{
    public static class DbInitializer
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.Channel.Any())
            {
                context.Channel.Add(new Models.Channel { Name = "I'm Here", IsActive = true });
                context.SaveChanges();
            }
        }
    }
}
