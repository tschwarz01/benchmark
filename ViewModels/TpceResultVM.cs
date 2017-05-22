using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace benchmark.ViewModels
{
    public class TpceResultVM
    {
        public int Id { get; set; }
        public string ProductNameFull { get; set; }
        public double Tpse { get; set; }

        public double TpseCore { get; set; }
    }
}
