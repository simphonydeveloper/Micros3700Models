using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_mtx_vctr_dtl
    {
        public int mtx_seq { get; set; }
        public DateTime mtx_date { get; set; }
        public double? ttl { get; set; }
        public short? mtx_prd { get; set; }
        public short? mtx_intv { get; set; }
        public string ob_edited { get; set; }
    }
}
