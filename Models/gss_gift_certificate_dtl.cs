using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_gift_certificate_dtl
    {
        public int gift_certificate_dtl_seq { get; set; }
        public int gift_certificate_seq { get; set; }
        public DateTime? sold_date { get; set; }
        public DateTime? expire_date { get; set; }
        public decimal sold_value { get; set; }
        public decimal? current_value { get; set; }
        public DateTime? date_redeemed { get; set; }
        public int? redeem_count { get; set; }
        public string purchaser { get; set; }
        public string recipient { get; set; }
        public string card_data { get; set; }
        public int? emp_seq { get; set; }
        public int? check_num { get; set; }
        public DateTime? chk_open_tm { get; set; }
        public string finalized { get; set; }
        [Column("void")]
        public string void_2 { get; set; }
    }
}
