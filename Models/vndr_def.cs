using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class vndr_def
    {
        public int vndr_seq { get; set; }
        public string name { get; set; }
        public string upper_name { get; set; }
        public int obj_num { get; set; }
        public string addr_ln_1_num { get; set; }
        public string addr_ln_1_name { get; set; }
        public string addr_ln_2 { get; set; }
        public string addr_ln_3 { get; set; }
        public string addr_ln_4 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string cntry { get; set; }
        public string postal_code { get; set; }
        public string contact_1 { get; set; }
        public string contact_2 { get; set; }
        public string area_code_1 { get; set; }
        public string local_num_1 { get; set; }
        public string ext_1 { get; set; }
        public string area_code_2 { get; set; }
        public string local_num_2 { get; set; }
        public string ext_2 { get; set; }
        public string fax_area_code { get; set; }
        public string fax_local_num { get; set; }
        public string e_mail_addr { get; set; }
        public string vndr_acct_id { get; set; }
        public string ap_acct_id { get; set; }
        public string fed_tax_id { get; set; }
        public string state_tax_id { get; set; }
        public double? min_ordr_amt { get; set; }
        public short? pymnt_term { get; set; }
        public short? num_net_day { get; set; }
        public double? ttl_credit { get; set; }
        public double? dsc_amt { get; set; }
        public double? dsc_pct { get; set; }
        public string ob_ordr_mon { get; set; }
        public short? rcv_mon_ordr { get; set; }
        public string ob_ordr_tue { get; set; }
        public short? rcv_tue_ordr { get; set; }
        public string ob_ordr_wed { get; set; }
        public short? rcv_wed_ordr { get; set; }
        public string ob_ordr_thu { get; set; }
        public short? rcv_thur_ordr { get; set; }
        public string ob_ordr_fri { get; set; }
        public short? rcv_fri_ordr { get; set; }
        public string ob_ordr_sat { get; set; }
        public short? rcv_sat_ordr { get; set; }
        public string ob_ordr_sun { get; set; }
        public short? rcv_sun_ordr { get; set; }
        public DateTime? ordr_deadline_tm { get; set; }
        public short? deflt_lead_day { get; set; }
        public short? ordr_mthd { get; set; }
        public string del_mthd { get; set; }
        public short? rcv_doc_type { get; set; }
        public short? rcv_doc_sort_ordr { get; set; }
        public short? init_rcv_doc_sort_ordr { get; set; }
        public int? cncy_seq { get; set; }
        public string cmnt_ln { get; set; }
        public string ob_invc_date_to_rcv_date { get; set; }
        public string ob_rcv_doc_contains_price { get; set; }
        public DateTime? sched_del_tm { get; set; }
        public int? acct_seq { get; set; }
        public short? revised_ordr_send_format { get; set; }
        public string ob_alw_pymnt_term_ovrde { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public string web_addr { get; set; }
        public long? multi_user_access_seq { get; set; }
        public string ob_is_store { get; set; }
        public string ob_consented { get; set; }
    }
}
