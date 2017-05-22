using benchmark.Entities;
using benchmark.Infrastructure;
using benchmark.Infrastructure.Repositories;
using benchmark.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace benchmark.Controllers.api
{
    [EnableCors("AnyGET")]
    [Route("api/[controller]")]
    //[Authorize]
    public class ProcessorsController : Controller
    {
        private readonly BenchDbContext _context;
        IProcessorRepository _processorRepository;
        IProcessorBrandRepository _brandRepository;

        public ProcessorsController(BenchDbContext context, IProcessorRepository processorRepository, IProcessorBrandRepository brandRepository)
        {
            _context = context;
            _processorRepository = processorRepository;
            _brandRepository = brandRepository;
        }

        // GET: api/processors
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _processorRepository.AllIncludingAsync(p => p.ProcessorBrand, p => p.ProductCodename, p => p.ProductFamily, p => p.ProductSeries);

            return new OkObjectResult(result);        
        }


        [HttpGet("names")]
        public async Task<List<CpuListVM>> NamesOnly()
        {
            return await _processorRepository.GetShortCpuAsync();
        }

        // GET: api/processors/27092
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
           var result = await _processorRepository.GetSingleAsync(id, p => p.ProcessorBrand, p => p.ProductCodename, p => p.ProductFamily, p => p.ProductSeries);
            
           return new OkObjectResult(result);
        }

        // GET:  api/processors/num/{ProcessNumber} (string)
        [HttpGet("num/{procnum}")]
        public async Task<IActionResult> GetProcInfo(string procnum)
        {
            var result = await _processorRepository.FindByAsync(p => p.ProcessorNumber == procnum);

            return new OkObjectResult(result);
        }

        // GET: api/processors/brands
        [HttpGet("Brands")]
        public async Task<IActionResult> GetBrands()
        {
            var brands = await _context.ProcessorBrands
                .Include(b => b.Processors)
                .ToListAsync();

            return new OkObjectResult(brands);
        }

        // GET: api/processors/brands
        [HttpGet("BrandsVM")]
        public IActionResult GetBrandsVM()
        {
            var _brands = _brandRepository
                            .AllIncluding(b => b.Processors)
                            .OrderBy(p => p.Id)
                            .Select(b => new BrandViewModel()
                            {
                                BrandId = b.Id,
                                BrandName = b.BrandName,
                                ProcessorNames = b.Processors.Select(i => i.ProductName).ToList()
                            })
                            .ToList();

            return new OkObjectResult(_brands);
        }

    }
}
