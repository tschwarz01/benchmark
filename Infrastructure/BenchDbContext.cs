using benchmark.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace benchmark.Infrastructure
{
    public class BenchDbContext : DbContext
    {
        

        public DbSet<Processor> Processors { get; set; }
        public DbSet<ProcessorBrand> ProcessorBrands { get; set; }
        public DbSet<ProductCodename> ProductCodenames { get; set; }
        public DbSet<ProductFamily> ProductFamilies { get; set; }
        public DbSet<ProductSeries> ProductSeries { get; set; }
        public DbSet<TpcE> BMTpcE { get; set; }

        public BenchDbContext(DbContextOptions<BenchDbContext> options) : base(options)
        {        }

    }
}
