using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class dsvc_dtl
    {
        public int trans_seq { get; set; }
        public int dtl_seq { get; set; }
        public int? parent_trans_seq { get; set; }
        public int? parent_dtl_seq { get; set; }
        public int? sttl_parent_trans_seq { get; set; }
        public int? sttl_parent_dtl_seq { get; set; }
        public int dsvc_seq { get; set; }
        public int? emp_meal_emp { get; set; }
        public string ob_dsvc1_amount { get; set; }
        public string ob_dsc1_item_disc { get; set; }
        public string ob_prorated { get; set; }
        public decimal? percentage { get; set; }
        public string ob_tax_1_exempt { get; set; }
        public string ob_tax_2_exempt { get; set; }
        public string ob_tax_3_exempt { get; set; }
        public string ob_tax_4_exempt { get; set; }
        public string ob_tax_5_exempt { get; set; }
        public string ob_tax_6_exempt { get; set; }
        public string ob_tax_7_exempt { get; set; }
        public string ob_tax_8_exempt { get; set; }
        public byte[] type_def { get; set; }
        public int? cm_till_id { get; set; }
        public int? parent_dtl_id { get; set; }
        public int? tid_ref { get; set; }
        public int? tid_inst_id { get; set; }
        public int? print_class_seq { get; set; }
        public string ob_rpt_as_sttl_dsc { get; set; }
        public int? mi_seq { get; set; }
        public short? mi_price_lvl { get; set; }
        public decimal? coupon_amount { get; set; }
        public short? consolidation_group { get; set; }
    }
}
