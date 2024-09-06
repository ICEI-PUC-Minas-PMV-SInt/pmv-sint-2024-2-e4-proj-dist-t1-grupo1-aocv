using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Timely.Models;

namespace Timely.Models
{
    public class TimelyContext : DbContext
    {
        public TimelyContext(DbContextOptions<TimelyContext> options) : base(options)
        {

        }
        
        public DbSet<Viagens>  Viagens {get; set; }
    }
}