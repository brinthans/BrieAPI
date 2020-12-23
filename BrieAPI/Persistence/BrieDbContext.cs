using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrieAPI.Persistence
{
    public class BrieDbContext : DbContext
    {
        public BrieDbContext(DbContextOptions<BrieDbContext> options) : base(options)
        {

        }

    }
}
