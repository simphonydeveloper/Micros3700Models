using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class sched_def
    {
        public int sched_seq { get; set; }
        public string name { get; set; }
        public short? sched_type { get; set; }
        public DateTime? specific_date { get; set; }
        public DateTime? ordr_deadline_tm { get; set; }
        public string ob_recurring { get; set; }
        public short sched_frq { get; set; }
        public short? sched_frq_intv { get; set; }
        public short? sched_frq_mthd { get; set; }
        public short? sched_frq_specific_day { get; set; }
        public short? sched_frq_annual_month { get; set; }
        public short? sched_frq_ordinal { get; set; }
        public short? sched_mthd_day { get; set; }
        public string ob_sched_mon { get; set; }
        public string ob_sched_tue { get; set; }
        public string ob_sched_wed { get; set; }
        public string ob_sched_thu { get; set; }
        public string ob_sched_fri { get; set; }
        public string ob_sched_sat { get; set; }
        public string ob_sched_sun { get; set; }
        public DateTime? sched_start_date { get; set; }
        public DateTime? sched_end_date { get; set; }
        public DateTime? sched_dly_tm_1 { get; set; }
        public DateTime? sched_dly_tm_2 { get; set; }
        public DateTime? sched_dly_tm_3 { get; set; }
        public DateTime? sched_dly_tm_4 { get; set; }
        public short? sched_inven_cnt_mthd { get; set; }
        public int? sched_par_lvl_seq { get; set; }
        public string ob_sched_single_loc_prn { get; set; }
        public short? sched_mon_del_day { get; set; }
        public short? sched_tue_del_day { get; set; }
        public short? sched_wed_del_day { get; set; }
        public short? sched_thu_del_day { get; set; }
        public short? sched_fri_del_day { get; set; }
        public short? sched_sat_del_day { get; set; }
        public short? sched_sun_del_day { get; set; }
        public short? clsd_bus_option { get; set; }
        public int? inven_cnt_task_seq { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public int? vndr_seq { get; set; }
        public int? sched_mgrlog_seq { get; set; }
        public string ob_rtn { get; set; }
        public string ob_auto_1 { get; set; }
        public string ob_auto_2 { get; set; }
        public string ob_auto_3 { get; set; }
        public string ob_auto_4 { get; set; }
        public long? multi_user_access_seq { get; set; }
        public string ob_must_complete { get; set; }
    }
}
