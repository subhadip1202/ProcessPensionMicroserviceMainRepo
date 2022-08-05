using Microsoft.EntityFrameworkCore;
using ProcessPensionMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessPensionMicroservice.Data
{
    public class MThreePensionDbContext : DbContext
    {
        public MThreePensionDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PensionDetail> pensionDetails { get; set; }

    }
}
