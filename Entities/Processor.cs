using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace benchmark.Entities
{
    public class Processor : IEntityBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }        
        public string ProductNameFull { get; set; }
        public string ProductName { get; set; }
        public string ProductNameDetails { get; set; }
        public string ProcessorNumber { get; set; }
        public int? MaxCPUs { get; set; }
        public int CoreCount { get; set; }
        public int? ThreadCount { get; set; }
        public int ClockSpeedMhz { get; set; }
        public double? ClockSpeedMaxMhz { get; set; }
        public string Cache { get; set; }
        public int? CacheKB { get; set; }
        public string CacheType { get; set; }
        public string MarketSegment { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? LaunchDate { get; set; }
        public string Url { get; set; }

        public int ProductFamilyId { get; set; }
        public int ProductSeriesId { get; set; }
        public int ProcessorBrandId { get; set; }
        public int ProductCodenameId { get; set; }
        public virtual ProcessorBrand ProcessorBrand { get; set; }
        public virtual ProductFamily ProductFamily { get; set; }
        public virtual ProductSeries ProductSeries { get; set; }
        public virtual ProductCodename ProductCodename { get; set; }

        public override string ToString()
        {
            return ProductNameFull;
        }
    }
}
