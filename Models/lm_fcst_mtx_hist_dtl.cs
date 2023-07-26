using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_fcst_mtx_hist_dtl
    {
        public int mtx_seq { get; set; }
        public DateTime mtx_date { get; set; }
        public int fcst_mtx_hist_seq { get; set; }
        public DateTime? actual_mtx_date { get; set; }
        public int? actual_mtx_seq { get; set; }
        public double? weight_percentage { get; set; }
    }
}
