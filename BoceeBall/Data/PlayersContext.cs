using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BoceeBall.Models;

namespace BoceeBall.Data
{
    class PlayersContext : DbContext
    {
        public PlayersContext() : base("name=DefaultConnection")
        {

        }

        public DbSet<Players> Players { get; set; }
        public DbSet<Teams> Teams { get; set; }
        public DbSet<Games> Games{ get; set; }
    }
}

