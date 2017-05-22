using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace benchmark.ViewModels
{
    public class CpuListVM
    {
        public int Id { get; set; }
        [DisplayName("Processor Name")]
        public string ProductName { get; set; }
        [DisplayName("Summary Details")]
        public string ProductNameDetails { get; set; }
        public string ProductNameFull { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? LaunchDate { get; set; }

        public int CoreCount { get; set; }
        public int? ThreadCount { get; set; }
        public int? ClockSpeedMhz { get; set; }
        public double? ClockSpeedMaxMhz { get; set; }
        public string ProductSeries { get; set; }
        public string ProductFamily { get; set; }
        public string ProductCodename { get; set; }
        public string ProcessorBrand { get; set; }

        public string Url { get; set; }

    }
}
