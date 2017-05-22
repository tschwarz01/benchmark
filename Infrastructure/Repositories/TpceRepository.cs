using benchmark.Entities;
using benchmark.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace benchmark.Infrastructure.Repositories
{
    public class TpceRepository : EntityBaseRepository<TpcE>, ITpceRepository
    {
        public TpceRepository(BenchDbContext context) : base(context) { }

        //public async Task<TpceEstimateVM> EstimateScore(Processor tgtProc)
        //{

        //    IEnumerable<TpcE> bmResults = await FindByAsync(b => b.ProductSeriesId == tgtProc.ProductSeriesId, b => b.Processor);

            
        //    double bmTpseAvg = bmResults.Average(b => b.TpsE);
        //    double bmTpseMax = bmResults.Max(b => b.TpsE);
        //    double bmTpseMin = bmResults.Min(b => b.TpsE);

        //    TpcE bm = bmResults.Where(b => b.ProcessorCount < 9).OrderByDescending(b => b.TpsE).First();
        //    Processor refProc = bm.Processor;

        //    decimal coreDiff = Decimal.Divide(tgtProc.CoreCount, refProc.CoreCount);
        //    double clockDiff = (double)tgtProc.ClockSpeedMhz / refProc.ClockSpeedMhz;
        //    double estTpse = bm.TpsePerSocket * (double)coreDiff * clockDiff;

        //    TpceEstimateVM _vm = new TpceEstimateVM()
        //    {
        //        Notes = $"Results based on {bmResults.Count()} TPC-E benchmarks for the reference processor ({refProc.ProductName}) in a {bm.ProcessorCount} socket configuration",
        //        AvgCpuScore = bmTpseAvg,
        //        MinCpuScore = bmTpseMin,
        //        MaxCpuScore = bmTpseMax,
        //        TargetProcessor = tgtProc.ProductName,
        //        TargetCpuScoreEstimate = estTpse,
        //        TargetCpuScorePerCoreEstimate = estTpse / tgtProc.CoreCount
        //    };

        //    return _vm;
        //}

        public async Task<TpceResultVM> EstimateScore(Processor tgtProc)
        {
            IEnumerable<TpcE> bmResults = await FindByAsync(b => b.ProductSeriesId == tgtProc.ProductSeriesId, b => b.Processor);

            TpcE bm = bmResults.Where(b => b.ProcessorCount < 9).OrderByDescending(b => b.TpsE).First();
            Processor refProc = bm.Processor;

            decimal coreDiff = Decimal.Divide(tgtProc.CoreCount, refProc.CoreCount);
            double clockDiff = (double)tgtProc.ClockSpeedMhz / refProc.ClockSpeedMhz;
            double estTpse = bm.TpsePerSocket * (double)coreDiff * clockDiff;

            TpceResultVM _vm = new TpceResultVM()
            {
                Id = tgtProc.Id,
                ProductNameFull = tgtProc.ProductNameFull,
                Tpse = estTpse,
                TpseCore = estTpse / tgtProc.CoreCount
            };

            return _vm;
        }
    }
}
