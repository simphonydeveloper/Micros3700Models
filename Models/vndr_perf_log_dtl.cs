using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class vndr_perf_log_dtl
    {
        public int inven_itm_seq { get; set; }
        public int? ordr_seq { get; set; }
        public int? ordr_itm_seq { get; set; }
        public int vndr_perf_code_seq { get; set; }
        public string cmnt_ln { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
