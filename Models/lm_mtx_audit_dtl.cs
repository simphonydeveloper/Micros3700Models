using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_mtx_audit_dtl
    {
        public int mtx_seq { get; set; }
        public DateTime mtx_date { get; set; }
        public int audit_seq { get; set; }
        public int? action { get; set; }
        public int? action_by { get; set; }
        public DateTime? action_date { get; set; }
    }
}
