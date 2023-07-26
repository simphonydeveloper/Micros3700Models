using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_gift_value_add_dtl
    {
        public int gift_value_add_dtl_seq { get; set; }
        public int gift_certificate_dtl_seq { get; set; }
        public DateTime? tran_date { get; set; }
        public decimal? amount { get; set; }
        public int? emp_seq { get; set; }
        public int? check_num { get; set; }
        public DateTime? chk_open_tm { get; set; }
        public string finalized { get; set; }
        [Column("void")]
        public string void_2 { get; set; }
    }
}
