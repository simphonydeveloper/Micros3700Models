using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class trans_archive_dtl
    {
        public long PKEY_ID { get; set; }
        public int? T_trans_seq { get; set; }
        public string T_type { get; set; }
        public int? T_fixed_period_seq { get; set; }
        public DateTime? T_business_date { get; set; }
        public DateTime? T_start_date { get; set; }
        public TimeSpan? T_start_tm { get; set; }
        public DateTime? T_end_date { get; set; }
        public DateTime? T_end_tm { get; set; }
        public int? T_training_status { get; set; }
        public int? T_rvc_seq { get; set; }
        public int? T_uws_seq { get; set; }
        public int? RVCDEF_obj_num { get; set; }
        public string RVCDEF_name { get; set; }
        public int? UWSDEF_obj_num { get; set; }
        public string DEVDEF_name { get; set; }
        public int? TEMPDEF_obj_num { get; set; }
        public string TEMPDEF_chk_name { get; set; }
        public int? CSHRDEF_obj_num { get; set; }
        public string CSHRDEF_name { get; set; }
        public int? AEMPDEF_obj_num { get; set; }
        public string AEMPDEF_chk_name { get; set; }
        public string AEMPDEF_first_name { get; set; }
        public int? AEMPDEF_emp_seq { get; set; }
        public int? C_chk_seq { get; set; }
        public int? C_num_chk_info_lines { get; set; }
        public int? C_order_type_seq { get; set; }
        public int? C_chk_num { get; set; }
        public string C_id { get; set; }
        public string C_chk_open { get; set; }
        public DateTime? C_chk_open_date { get; set; }
        public TimeSpan? C_chk_open_tm { get; set; }
        public DateTime? C_chk_clsd_date { get; set; }
        public TimeSpan? C_chk_clsd_tm { get; set; }
        public string C_chk_reopened { get; set; }
        public int? C_grp { get; set; }
        public int? C_cov_cnt { get; set; }
        public decimal? C_sub_ttl { get; set; }
        public decimal? C_svc_ttl { get; set; }
        public decimal? C_tax_ttl { get; set; }
        public decimal? C_pymnt_ttl { get; set; }
        public string ORDTYPE_name { get; set; }
        public int? TBLDEF_obj_num { get; set; }
        public string TBLDEF_name { get; set; }
        public int? REASONDEF_obj_num { get; set; }
        public int? REASONDEF_obj_num2 { get; set; }
        public int? REASONDEF_obj_num3 { get; set; }
        public string REASONDEF_name { get; set; }
        public int? CEMPDEF_obj_num { get; set; }
        public string CEMPDEF_chk_name { get; set; }
        public string CEMPDEF_first_name { get; set; }
        public int? CEMPDEF_emp_seq { get; set; }
        public int? S_mgr_void_cnt { get; set; }
        public decimal? S_mgr_void_ttl { get; set; }
        public int? D_dtl_seq { get; set; }
        public string D_dtl_type { get; set; }
        public string D_record_type { get; set; }
        public int? D_dtl_index { get; set; }
        public int? D_dtl_id { get; set; }
        public byte[] D_dtl_status { get; set; }
        public string D_ob_dtl05_void_flag { get; set; }
        public int? D_auth_emp { get; set; }
        public int? D_reason_seq { get; set; }
        public int? D_rpt_cnt { get; set; }
        public decimal? D_rpt_ttl { get; set; }
        public string D_ob_error_correct { get; set; }
        public string M_ob_dtl04_rtn { get; set; }
        public int? M_price_lvl { get; set; }
        public decimal? M_item_weight { get; set; }
        public int? MIDEF_obj_num { get; set; }
        public string MIDEF_name { get; set; }
        public int? MIGRPDEF_obj_num { get; set; }
        public string MIGRPDEF_name { get; set; }
        public int? MAJGRPDEF_obj_num { get; set; }
        public string MAJGRPDEF_name { get; set; }
        public int? FAMGRPDEF_obj_num { get; set; }
        public string FAMGRPDEF_name { get; set; }
        public string P_ob_tax_1_exempt { get; set; }
        public string P_ob_tax_2_exempt { get; set; }
        public string P_ob_tax_3_exempt { get; set; }
        public string P_ob_tax_4_exempt { get; set; }
        public string P_ob_tax_5_exempt { get; set; }
        public string P_ob_tax_6_exempt { get; set; }
        public string P_ob_tax_7_exempt { get; set; }
        public string P_ob_tax_8_exempt { get; set; }
        public string P_tax_exempt { get; set; }
        public string P_autogratuity_exempt { get; set; }
        public string P_cc_acct_num { get; set; }
        public decimal? P_chg_tip_ttl { get; set; }
        public decimal? P_chg_subttl { get; set; }
        public int? TMEDDEF_obj_num { get; set; }
        public string TMEDDEF_name { get; set; }
        public string TMEDDEF_type { get; set; }
        public decimal? DC_percentage { get; set; }
        public int? DC_sttl_parent_dtl_seq { get; set; }
        public int? DCDEF_obj_num { get; set; }
        public string DCDEF_name { get; set; }
        public string DCDEF_type { get; set; }
        public decimal? DCDEF_amt { get; set; }
        public decimal? DCDEF_percentage { get; set; }
        public decimal? SV_percentage { get; set; }
        public int? SVDEF_obj_num { get; set; }
        public string SVDEF_name { get; set; }
        public string SVDEF_type { get; set; }
        public decimal? SVDEF_amt { get; set; }
        public decimal? SVDEF_percentage { get; set; }
        public string SVDEF_ob_non_revenue { get; set; }
        public int? SRVPRDDEF_obj_num { get; set; }
        public string SRVPRDDEF_name { get; set; }
        public string R_ref { get; set; }
        public string R_type { get; set; }
        public int? MIDEF_cond_grp_mem_seq { get; set; }
        public string D_dtl_name { get; set; }
        public int? D_chk_cnt { get; set; }
        public decimal? D_chk_ttl { get; set; }
        public string C_use_VAT { get; set; }
    }
}
