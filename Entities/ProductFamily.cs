using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace benchmark.Entities
{
    public class ProductFamily : IEntityBase
    {
        public ProductFamily()
        {
            Processors = new List<Processor>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string FamilyName { get; set; }

        public virtual ICollection<Processor> Processors { get; set; }

        public override string ToString()
        {
            return FamilyName;
        }
    }
}
