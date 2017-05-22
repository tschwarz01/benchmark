using benchmark.Entities;
using benchmark.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace benchmark.Infrastructure.Repositories
{
    public class ProcessorRepository : EntityBaseRepository<Processor>, IProcessorRepository
    {
        BenchDbContext _ctx;
        public ProcessorRepository(BenchDbContext context) : base(context) { _ctx = context; }
        public virtual async Task<List<CpuListVM>> GetShortCpuAsync()
        {
            
            List<CpuListVM> result = await _ctx.Processors
                                                .Include(p => p.ProcessorBrand)
                                                .Include(p => p.ProductCodename)
                                                .Include(p => p.ProductFamily)
                                                .Include(p => p.ProductSeries)
                                                .Select(p => new CpuListVM {
                Id = p.Id,
                ProductName = p.ProductName,
                ProductNameDetails = p.ProductNameDetails,
                ProductNameFull = p.ProductNameFull,
                LaunchDate = p.LaunchDate,
                CoreCount = p.CoreCount,
                ThreadCount = p.ThreadCount,
                ClockSpeedMaxMhz = p.ClockSpeedMaxMhz,
                ClockSpeedMhz = p.ClockSpeedMhz,
                ProductSeries = p.ProductSeries.SeriesName,
                ProductFamily = p.ProductFamily.FamilyName,
                ProductCodename = p.ProductCodename.Codename,
                ProcessorBrand = p.ProcessorBrand.BrandName,
                Url = p.Url

            }).OrderByDescending(p => p.LaunchDate).ToListAsync();

            return result;
        }
    }
}
