using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class tmed_dtl
    {
        public int trans_seq { get; set; }
        public int dtl_seq { get; set; }
        public int tmed_seq { get; set; }
        public int? other_emp_seq { get; set; }
        public string ob_tax_1_exempt { get; set; }
        public string ob_tax_2_exempt { get; set; }
        public string ob_tax_3_exempt { get; set; }
        public string ob_tax_4_exempt { get; set; }
        public string ob_tax_5_exempt { get; set; }
        public string ob_tax_6_exempt { get; set; }
        public string ob_tax_7_exempt { get; set; }
        public string ob_tax_8_exempt { get; set; }
        public string cc_acct_num { get; set; }
        public string expiration_date { get; set; }
        public decimal chg_tip_ttl { get; set; }
        public decimal allocated_tax_ttl { get; set; }
        public byte[] type_def { get; set; }
        public string ob_immed_pymnt { get; set; }
        public string ob_tips_paid { get; set; }
        public int? frgn_cncy_seq { get; set; }
        public decimal? frgn_cncy_ttl { get; set; }
        public short? frgn_cncy_num_decimal_places { get; set; }
        public decimal? cashback_ttl { get; set; }
        public int? cm_till_id { get; set; }
        public string ssn { get; set; }
        public string pers_chk_transit_num { get; set; }
        public string pers_chk_acct_num { get; set; }
        public string pers_chk_chk_num { get; set; }
        public int? print_class_seq { get; set; }
        public int? pms_if_seq { get; set; }
        public int? encrypt_value_seq { get; set; }
        public byte[] tray_totaled_seat_map { get; set; }
        public byte[] eAcctNum { get; set; }
        public byte[] eExpDate { get; set; }
        public byte[] hAcctNum { get; set; }
        public int? link_dtl_id { get; set; }
    }
}
