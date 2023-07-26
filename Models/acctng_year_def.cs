using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class acctng_year_def
    {
        public int acctng_year_seq { get; set; }
        public short acctng_cycle_frq_type { get; set; }
        public string name { get; set; }
        public int obj_num { get; set; }
        public string ob_summarize_grp { get; set; }
        public DateTime begin_date { get; set; }
        public DateTime end_date { get; set; }
        public string ob_float_prd_day_of_wk { get; set; }
        public string ob_float_fiscal_start_date { get; set; }
        public short? bus_wk_start_day { get; set; }
        public string fiscal_prd_name { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public long? multi_user_access_seq { get; set; }
    }
}
