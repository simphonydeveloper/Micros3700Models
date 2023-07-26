using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_gift_certificate_def
    {
        public int gift_certificate_seq { get; set; }
        public string name { get; set; }
        public DateTime? sell_from { get; set; }
        public DateTime? sell_to { get; set; }
        public int expire_type { get; set; }
        public int? expire_type_number { get; set; }
        public DateTime? expire_date { get; set; }
        public string redeem_after_expired { get; set; }
        public string allow_partial_redeem { get; set; }
        public int refund_method { get; set; }
        public string use_gift_cards { get; set; }
        public string prompt_for_names { get; set; }
        public int? min_key { get; set; }
        public int? max_key { get; set; }
    }
}
