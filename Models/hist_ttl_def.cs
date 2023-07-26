using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class hist_ttl_def
    {
        public int hist_ttl_seq { get; set; }
        public string hist_ttl_name { get; set; }
        public string hist_ttl_logical_name { get; set; }
        public int? hist_ttl_type_seq { get; set; }
        public int? last_trans_seq { get; set; }
        public DateTime? last_trans_seq_date { get; set; }
        public int? consolidate_period { get; set; }
        public string ob_em_centralize_ttl { get; set; }
        public DateTime? last_purge_cutoff_date { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
