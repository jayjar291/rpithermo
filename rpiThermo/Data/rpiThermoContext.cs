using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace rpiThermo.Models
{
    public class rpiThermoContext : DbContext
    {
        public rpiThermoContext (DbContextOptions<rpiThermoContext> options)
            : base(options)
        {
        }

        public DbSet<rpiThermo.Models.Schedule> Schedule { get; set; }
    }
}
