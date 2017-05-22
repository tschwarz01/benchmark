using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace benchmark.ViewModels
{
    public class BrandViewModel
    {
        public BrandViewModel()
        {
        }
        [DisplayName("Brand ID")]
        public int BrandId { get; set; }
        [DisplayName("Intel Brand Name")]
        public string BrandName { get; set; }
        [DisplayName("Processors")]
        public List<string> ProcessorNames { get; set; }
    }
}
