using benchmark.Entities;
using benchmark.Infrastructure;
using benchmark.Infrastructure.Repositories;
using benchmark.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace benchmark.Controllers.api
{
    [Route("api/[controller]")]
    public class BenchmarkController : Controller
    {
        private readonly BenchDbContext _context;
        IProcessorRepository _processorRepository;
        ITpceRepository _tpceRepository;

        public BenchmarkController(BenchDbContext context, IProcessorRepository processorRepository, ITpceRepository tpceRepository)
        {
            _context = context;
            _processorRepository = processorRepository;
            _tpceRepository = tpceRepository;
        }

        // API:  Get all TPCE results
        [HttpGet("1")]
        public async Task<IActionResult> Get()
        {
            //var result = await _tpceRepository.AllIncludingAsync(p => p.Processor, p => p.ProductSeries);
            var result = await _tpceRepository.GetAllAsync();

            return new OkObjectResult(result);
        }

        // GET:  api/Benchmark/tpce/{ProcessorId}
        [HttpGet("tpce/{processorId}")]
        public async Task<IActionResult> GetBM(int processorId)
        {
            Processor tgtProc = await _processorRepository.GetSingleAsync(processorId);

            if (tgtProc == null)
            {
                return NotFound();
            }

            TpceResultVM result = await _tpceRepository.EstimateScore(tgtProc);

            return new OkObjectResult(result);
        }



    }
}
