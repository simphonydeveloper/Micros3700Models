using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class vndr_perf_code_def
    {
        public int vndr_perf_code_seq { get; set; }
        public string vndr_perf_id { get; set; }
        public string vndr_perf_desc { get; set; }
        public short? vndr_perf_idx { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
