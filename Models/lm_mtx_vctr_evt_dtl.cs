using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_mtx_vctr_evt_dtl
    {
        public int evt_seq { get; set; }
        public int mtx_seq { get; set; }
        public DateTime mtx_date { get; set; }
    }
}
