using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class su_aseq_def
    {
        public int su_aseq_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public short? priv_group { get; set; }
        public int? chain_to_seq { get; set; }
        public string ob_suao01_no_opn_chks { get; set; }
        public string ob_suao02_no_emp_opn_chks { get; set; }
        public string ob_suao03_not_on_run_scrn { get; set; }
        public string ob_suao04_range_sign_in_emp { get; set; }
        public string ob_suao05_no_clk_in { get; set; }
        public string ob_suao06_emp_off_after_run { get; set; }
        public string ob_suao07_confirm_before_run { get; set; }
        public string ob_suao08_chk_rvc_only { get; set; }
        public string ob_suao09_dont_chk_host_com { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
