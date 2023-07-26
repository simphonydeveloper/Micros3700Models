using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cc_vchr_dtl
    {
        public int trans_seq { get; set; }
        public int dtl_seq { get; set; }
        public string cc_acct_num { get; set; }
        public decimal vchr_amt { get; set; }
        public string ob_reprinted_vchr { get; set; }
        public int? encrypt_value_seq { get; set; }
        public int? cc_vchr_custom_seq { get; set; }
        public byte[] eAcctNum { get; set; }
        public byte[] hAcctNum { get; set; }
        public int? tmed_seq { get; set; }
        public int? parent_dtl_id { get; set; }
    }
}
