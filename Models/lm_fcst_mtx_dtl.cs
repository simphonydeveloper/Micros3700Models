using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_fcst_mtx_dtl
    {
        public int fcst_ele_seq { get; set; }
        public int fcst_dtl_seq { get; set; }
        public int? mtx_seq { get; set; }
        public DateTime fcst_date { get; set; }
        public short fcst_state { get; set; }
        public short fcst_variable_type { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public int? approved_by { get; set; }
        public DateTime? approved_date { get; set; }
        public string ob_for_evt_adj { get; set; }
        public string ob_scalar { get; set; }
        public string ob_rsvd01 { get; set; }
        public string ob_rsvd02 { get; set; }
        public string ob_rsvd03 { get; set; }
        public int? num_rsvd01 { get; set; }
        public int? num_rsvd02 { get; set; }
        public double? scalar_val { get; set; }
    }
}
