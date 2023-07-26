using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class dashboard_cfg
    {
        public int dashboard_seq { get; set; }
        public string ob_qsr { get; set; }
        public string ob_disp_all_emp { get; set; }
        public string ob_run_contest { get; set; }
        public string ob_display_contest_info { get; set; }
        public string ob_display_kds_info { get; set; }
        public int? sls_alrt_lvl_1 { get; set; }
        public int? sls_alrt_lvl_2 { get; set; }
        public decimal? num_hrs_until_ovt { get; set; }
        public decimal? num_hrs_in_ovt { get; set; }
        public int? labor_alrt_1_lvl_1 { get; set; }
        public int? labor_alrt_1_lvl_2 { get; set; }
        public int? labor_alrt_2_lvl_1 { get; set; }
        public int? labor_alrt_2_lvl_2 { get; set; }
        public int? obj_num { get; set; }
        public int? kds_alrt_lvl_1 { get; set; }
        public int? kds_alrt_lvl_2 { get; set; }
        public decimal? num_hrs_until_dly_ovt { get; set; }
        public decimal? num_hrs_in_dly_ovt { get; set; }
        public string ob_hr_prd { get; set; }
        public short? max_drink_only_tm_red { get; set; }
        public short? max_drink_only_tm_yellow { get; set; }
        public short? max_dt_ave_tm_red { get; set; }
        public short? max_dt_ave_tm_yellow { get; set; }
        public short? max_dt_drink_only_tm_red { get; set; }
        public short? max_dt_drink_only_tm_yellow { get; set; }
        public short? max_dt_que_tm_red { get; set; }
        public short? max_dt_que_tm_yellow { get; set; }
        public short? max_dt_reply_tm_red { get; set; }
        public short? max_dt_reply_tm_yellow { get; set; }
        public short? max_dt_tray_tm_red { get; set; }
        public short? max_dt_tray_tm_yellow { get; set; }
        public short? max_dt_win_tm_red { get; set; }
        public short? max_dt_win_tm_yellow { get; set; }
        public short? max_st_reply_tm_red { get; set; }
        public short? max_st_reply_tm_yellow { get; set; }
        public short? max_st_ticket_tm_red { get; set; }
        public short? max_st_ticket_tm_yellow { get; set; }
        public short? max_st_tray_tm_red { get; set; }
        public short? max_st_tray_tm_yellow { get; set; }
        public short? max_ticket_tm_red { get; set; }
        public short? max_ticket_tm_yellow { get; set; }
        public short? max_tray_tm_red { get; set; }
        public short? max_tray_tm_yellow { get; set; }
        public short? max_ot_threshold { get; set; }
        public short? max_reply_tm_red { get; set; }
        public short? max_reply_tm_yellow { get; set; }
        public short? min_hop_pct_red { get; set; }
        public short? min_hop_pct_yellow { get; set; }
        public decimal? till_amt_alert { get; set; }
        public string ob_no_drive_thru { get; set; }
        public string ob_no_stall { get; set; }
    }
}
