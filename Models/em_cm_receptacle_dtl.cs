using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_cm_receptacle_dtl
    {
        public int store_id { get; set; }
        public int receptacle_seq { get; set; }
        public int? receptacle_type { get; set; }
        public DateTime? open_business_date { get; set; }
        public DateTime? open_timestamp { get; set; }
        public int? receptacle_state { get; set; }
        public string receptacle_name { get; set; }
        public decimal? starting_amount { get; set; }
        public int? deposit_receptacle { get; set; }
        public int? cm_accounting_method { get; set; }
        public int? countsheet_seq { get; set; }
        public decimal? cash_pull_accumulator { get; set; }
        public decimal? cash_pull_total { get; set; }
        public decimal? cash_pull_threshold { get; set; }
        public int? cash_pull_alert { get; set; }
        public int? num_cash_pull_chits_to_print { get; set; }
        public int? starting_amount_deposited { get; set; }
        public int? offline_receptacle_seq { get; set; }
        public string deposit_reference_data { get; set; }
        public int? parlevel_seq { get; set; }
        public string udf_reference { get; set; }
        public decimal? cash_pull_threshold_2 { get; set; }
        public decimal? cash_pull_threshold_3 { get; set; }
        public decimal? min_balance { get; set; }
        public decimal? max_balance { get; set; }
        public DateTime? open_timestamp_loc { get; set; }
        public int? cm_physical_till_seq { get; set; }
        public int? rvc_seq { get; set; }
    }
}
