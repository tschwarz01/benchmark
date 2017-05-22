using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace benchmark.Entities
{
    public class TpcE : IEntityBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ServerId { get; set; }
        public int ProcessorId { get; set; }
        public int ProductSeriesId { get; set; }
        public int ProcessorCount { get; set; }
        public int CoreCount { get; set; }
        public int ThreadCount { get; set; }
        public int MemorySizeGB { get; set; }
        public int InitialDatabaseSizeGB { get; set; }
        public int SpindleCount { get; set; }
        public double TpsE { get; set; }
        public double TpsePerSocket => TpsE / ProcessorCount;
        public double TpsePerCore => TpsE / CoreCount;
        public string TpcEnergyMetric { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ResultSubmitted { get; set; }
        public string HardwareVendor { get; set; }
        public string SystemModel { get; set; }
        public decimal TotalSystemCost { get; set; }
        public string Currency { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime SystemAvailability { get; set; }

        public virtual Processor Processor { get; set; }

    }
}
