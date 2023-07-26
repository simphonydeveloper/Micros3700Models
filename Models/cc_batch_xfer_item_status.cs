using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cc_batch_xfer_item_status
    {
        public int batch_seq { get; set; }
        public int settle_attempt_seq { get; set; }
        public int item_seq { get; set; }
        public string cc_acct_num { get; set; }
        public string expiration_date { get; set; }
        public string ob_manual_entry { get; set; }
        public short? chk_num { get; set; }
        public DateTime date_time { get; set; }
        public decimal base_ttl { get; set; }
        public decimal charge_tip_ttl { get; set; }
        public string omitted_by { get; set; }
        public string omit_desc { get; set; }
        public int? encrypt_value_seq { get; set; }
    }
}
