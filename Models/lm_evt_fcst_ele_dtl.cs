using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_evt_fcst_ele_dtl
    {
        public int evt_seq { get; set; }
        public int fcst_ele_seq { get; set; }
        public int? mtx_seq { get; set; }
        public double? adjmt_fctr { get; set; }
        public int? adjusted_by { get; set; }
        public DateTime? adjusted_date { get; set; }
        public string ob_omit_in_fcst { get; set; }
        public string ob_use_auto_calc { get; set; }
    }
}
