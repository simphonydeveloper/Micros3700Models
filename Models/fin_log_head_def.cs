using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class fin_log_head_def
    {
        public int fin_log_head_seq { get; set; }
        public int fin_prd_seq { get; set; }
        public int fin_config_seq { get; set; }
        public int fin_log_headref_seq { get; set; }
        public DateTime head_date { get; set; }
        public string head_desc { get; set; }
        public decimal total { get; set; }
        public string notes { get; set; }
        public int? spread_seq { get; set; }
    }
}
