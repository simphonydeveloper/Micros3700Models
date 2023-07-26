using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class tax_rate_juris_def
    {
        public int tax_juris_seq { get; set; }
        public int tax_rate_store_map { get; set; }
        public int? tax_rate_seq { get; set; }
    }
}
