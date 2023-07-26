using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class mi_ver_def
    {
        public int mi_seq { get; set; }
        public int version_seq { get; set; }
        public int? cond_allowed { get; set; }
        public int? cond_req { get; set; }
        public int? mlvl_class_seq { get; set; }
        public int? prn_def_class_seq { get; set; }
        public int? mi_type_seq { get; set; }
        public int? mi_slu_seq { get; set; }
        public int? crs_sel_seq { get; set; }
        public int? mi_slu2_seq { get; set; }
        public int? crs_mem_seq { get; set; }
        public int? cond_grp_mem_seq { get; set; }
        public decimal? nlu_num { get; set; }
        public short? nlu_grp { get; set; }
        public short? slu_priority { get; set; }
        public int? key_num { get; set; }
        public short? icon_id { get; set; }
        public string ob_mi31_chk_mi_avail { get; set; }
        public string ob_mi44_no_edit_in_mgr_proc { get; set; }
        public string ob_item_is_the_no_modifier { get; set; }
        public string ob_lite_mi_dirty { get; set; }
        public string ob_rsvd01 { get; set; }
        public string ob_rsvd02 { get; set; }
        public string ob_rsvd03 { get; set; }
        public string ob_rsvd04 { get; set; }
        public decimal? comm_amt { get; set; }
        public decimal? comm_pcnt { get; set; }
        public string cross_ref1 { get; set; }
        public string cross_ref2 { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public int? ob_flags { get; set; }
        public long? multi_user_access_seq { get; set; }
        public string ob_workstation_only { get; set; }
        public int? prep_time { get; set; }
        public int? external_type { get; set; }
        public int? topping_type_seq { get; set; }
        public int? topping_modifier_seq { get; set; }
        public short? prefix_override_level { get; set; }
        public short? prefix_override_count { get; set; }
        public int? build_screen_style_seq { get; set; }
        public int? hht_build_screen_style_seq { get; set; }
        public int? mi_slu3_seq { get; set; }
        public int? mi_slu4_seq { get; set; }
        public int? mi_slu5_seq { get; set; }
        public int? mi_slu6_seq { get; set; }
        public int? mi_slu7_seq { get; set; }
        public int? mi_slu8_seq { get; set; }
    }
}
