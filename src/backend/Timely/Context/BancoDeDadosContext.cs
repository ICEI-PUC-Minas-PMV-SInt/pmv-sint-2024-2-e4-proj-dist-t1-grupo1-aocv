using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Timely.Models;

namespace Timely.Context
{
    public class BancoDeDadosContext : DbContext
    {
        public BancoDeDadosContext(DbContextOptions<BancoDeDadosContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; } = default!;
    }


}