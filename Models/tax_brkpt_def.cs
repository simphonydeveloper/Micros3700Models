using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class tax_brkpt_def
    {
        public int tax_rate_seq { get; set; }
        public int tax_brkpnt_seq { get; set; }
        public short? amt { get; set; }
        public int? last_updated_by { get; set; }
    }
}
