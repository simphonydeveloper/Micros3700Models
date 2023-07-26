using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class prn_class_def
    {
        public int prn_def_class_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string ob_pl01_prn_cust_rcpt { get; set; }
        public string ob_pl02_prn_local_order_rcpt { get; set; }
        public string ob_pl03_prn_jnl { get; set; }
        public string ob_pl04_prn_rpt { get; set; }
        public string ob_pl05_prn_chk { get; set; }
        public string ob_pl09_prn_remote_ordr_1 { get; set; }
        public string ob_pl10_prn_remote_ordr_2 { get; set; }
        public string ob_pl11_prn_remote_ordr_3 { get; set; }
        public string ob_pl12_prn_remote_ordr_4 { get; set; }
        public string ob_pl13_prn_remote_ordr_5 { get; set; }
        public string ob_pl14_prn_remote_ordr_6 { get; set; }
        public string ob_pl15_prn_remote_ordr_7 { get; set; }
        public string ob_pl16_prn_remote_ordr_8 { get; set; }
        public string ob_pl17_prn_remote_ordr_9 { get; set; }
        public string ob_pl18_prn_remote_ordr_10 { get; set; }
        public string ob_pl19_prn_remote_ordr_11 { get; set; }
        public string ob_pl20_prn_remote_ordr_12 { get; set; }
        public string ob_pl21_prn_remote_ordr_13 { get; set; }
        public string ob_pl22_prn_remote_ordr_14 { get; set; }
        public string ob_pl23_prn_remote_ordr_15 { get; set; }
        public string ob_pl24_prn_remote_ordr_16 { get; set; }
        public string ob_pl25_prn_remote_ordr_17 { get; set; }
        public string ob_pl26_prn_remote_ordr_18 { get; set; }
        public string ob_pl27_prn_remote_ordr_19 { get; set; }
        public string ob_pl28_prn_remote_ordr_20 { get; set; }
        public string ob_pl29_prn_remote_ordr_21 { get; set; }
        public string ob_pl30_prn_remote_ordr_22 { get; set; }
        public string ob_pl31_prn_remote_ordr_23 { get; set; }
        public string ob_pl32_prn_remote_ordr_24 { get; set; }
        public string ob_pl33_prn_remote_ordr_25 { get; set; }
        public string ob_pl34_prn_remote_ordr_26 { get; set; }
        public string ob_pl35_prn_remote_ordr_27 { get; set; }
        public string ob_pl36_prn_remote_ordr_28 { get; set; }
        public string ob_pl37_prn_remote_ordr_29 { get; set; }
        public string ob_pl38_prn_remote_ordr_30 { get; set; }
        public string ob_pl39_prn_remote_ordr_31 { get; set; }
        public string ob_pl40_prn_remote_ordr_32 { get; set; }
        public string ob_pl24_prn_red_on_order_dev { get; set; }
        public string ob_prn_fcr { get; set; }
        public string ob_rsvd01 { get; set; }
        public string ob_rsvd02 { get; set; }
        public string ob_rsvd03 { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
