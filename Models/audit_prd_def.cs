using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class audit_prd_def
    {
        public int audit_prd_seq { get; set; }
        public string name { get; set; }
        public string audit_by { get; set; }
        public short audit_type { get; set; }
        public DateTime? begin_date { get; set; }
        public DateTime? end_date { get; set; }
        public short audit_close { get; set; }
        public string cmnt_ln { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
