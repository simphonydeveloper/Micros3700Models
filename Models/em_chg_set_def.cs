using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_chg_set_def
    {
        public decimal em_chg_set_seq { get; set; }
        public decimal? obj_num { get; set; }
        public string name { get; set; }
        public string status_flag { get; set; }
        public string msg_type { get; set; }
        public string chg_set_type { get; set; }
        public string ob_test_send { get; set; }
        public DateTime chg_set_ovrrd_effective_from { get; set; }
        public DateTime? chg_set_ovrrd_effective_to { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public string ob_store_ovrd_allowed { get; set; }
        public decimal? seq_id { get; set; }
    }
}
