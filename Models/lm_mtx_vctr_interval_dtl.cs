using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_mtx_vctr_interval_dtl
    {
        public int mtx_seq { get; set; }
        public DateTime mtx_date { get; set; }
        public int interval_seq { get; set; }
        public double? interval_value { get; set; }
    }
}
