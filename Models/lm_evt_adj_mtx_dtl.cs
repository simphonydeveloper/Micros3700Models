using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_evt_adj_mtx_dtl
    {
        public int evt_adj_grp_seq { get; set; }
        public int evt_adj_seq { get; set; }
        public int fcst_ele_seq { get; set; }
        public int evt_type_seq { get; set; }
        public int evt_seq { get; set; }
        public DateTime fcst_mtx_date { get; set; }
        public int fcst_mtx_seq { get; set; }
        public int avg_mtx_seq { get; set; }
        public short? ob_dirty { get; set; }
    }
}
