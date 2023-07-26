using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_award_gift_certificate_dtl
    {
        public int award_gift_certificate_dtl_seq { get; set; }
        public int? bonus_seq { get; set; }
        public int customer_seq { get; set; }
        public int gift_certificate_seq { get; set; }
        public int? gift_certificate_dtl_seq { get; set; }
        public int? uws_seq { get; set; }
        public int? emp_seq { get; set; }
        public DateTime award_date { get; set; }
        public decimal? gift_certificate_amount { get; set; }
        public DateTime? last_issue_date { get; set; }
        public int? issue_count { get; set; }
    }
}
