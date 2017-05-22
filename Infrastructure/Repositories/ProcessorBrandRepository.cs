using benchmark.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace benchmark.Infrastructure.Repositories
{
    public class ProcessorBrandRepository : EntityBaseRepository<ProcessorBrand>, IProcessorBrandRepository
    {
        public ProcessorBrandRepository(BenchDbContext context) : base(context) { }
    }
}
