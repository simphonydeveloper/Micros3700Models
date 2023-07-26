using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class encrypt_cc_value_dtl
    {
        public int encrypt_value_seq { get; set; }
        public int key_seq { get; set; }
        public string cc_acct_num { get; set; }
        public string customer_name { get; set; }
        public string exp_date { get; set; }
        public string track_data { get; set; }
        public byte[] hashcode { get; set; }
        public string emsr_track_1 { get; set; }
        public string emsr_track_2 { get; set; }
        public string emsr_ksn { get; set; }
    }
}
