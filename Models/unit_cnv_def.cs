using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class unit_cnv_def
    {
        public int to_unit_seq { get; set; }
        public int from_unit_seq { get; set; }
        public double cnv_fctr { get; set; }
        public string operation { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
