using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cond_grp_def
    {
        public int cond_grp_seq { get; set; }
        public string name { get; set; }
        public int? ts_style_seq { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public int? hht_ts_style_seq { get; set; }
        public string descriptor { get; set; }
    }
}
