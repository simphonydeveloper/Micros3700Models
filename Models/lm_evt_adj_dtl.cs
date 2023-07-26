using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_evt_adj_dtl
    {
        public int evt_adj_seq { get; set; }
        public int fcst_ele_seq { get; set; }
        public int evt_type_seq { get; set; }
        public int avg_adj_seq { get; set; }
        public short? dow { get; set; }
    }
}
