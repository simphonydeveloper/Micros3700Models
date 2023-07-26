using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class tax_class_juris_def
    {
        public int tax_class_seq { get; set; }
        public int tax_juris_seq { get; set; }
        public int tax_rate_store_map { get; set; }
        public string ob_rsvd { get; set; }
        public string ob_tax_active { get; set; }
    }
}
