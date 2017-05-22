using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace benchmark.ViewModels
{
    public class TpceEstimateVM
    {
        public string Notes { get; set; }
        public string ReferenceProcessor { get; set; }
        public double AvgCpuScore { get; set; }
        public double MinCpuScore { get; set; }
        public double MaxCpuScore { get; set; }
        public string TargetProcessor { get; set; }
        public double TargetCpuScoreEstimate { get; set; }
        public double TwoSocketEstimate => TargetCpuScoreEstimate * 2D;
        public double FourSocketEstimate => TargetCpuScoreEstimate * 4D;
        public double TargetCpuScorePerCoreEstimate { get; set; }

    }
}
