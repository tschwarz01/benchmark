using benchmark.Entities;
using benchmark.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace benchmark.Infrastructure.Repositories
{
    public interface IProcessorRepository : IEntityBaseRepository<Processor>
    {
        Task<List<CpuListVM>> GetShortCpuAsync();
    }

    public interface IProcessorBrandRepository : IEntityBaseRepository<ProcessorBrand> { }
    public interface ITpceRepository : IEntityBaseRepository<TpcE>
    {
        Task<TpceResultVM> EstimateScore(Processor tgtProc);
    }
}
