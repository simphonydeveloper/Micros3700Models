using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class prem_pay_def
    {
        public int prem_pay_seq { get; set; }
        public int obj_num { get; set; }
        public string prem_pay_name { get; set; }
        public string description { get; set; }
        public DateTime? effective_start_date { get; set; }
        public DateTime? effective_end_date { get; set; }
        public string prem_pay_type { get; set; }
        public short? day_of_wk { get; set; }
        public DateTime? cal_start_date { get; set; }
        public DateTime? cal_end_date { get; set; }
        public string incl_in_labor_cost { get; set; }
        public string incl_minors { get; set; }
        public short? start_time { get; set; }
        public short? end_time { get; set; }
        public string increase_type { get; set; }
        public decimal? increase_amt { get; set; }
        public string base_wage_type { get; set; }
        public decimal? flat_rate_amt { get; set; }
        public string incl_hrs_in_otm_calc { get; set; }
        public decimal? min_hrs_between_shifts { get; set; }
        public decimal? additional_hrs { get; set; }
        public DateTime? last_updated_date { get; set; }
        public int? last_updated_by { get; set; }
    }
}
