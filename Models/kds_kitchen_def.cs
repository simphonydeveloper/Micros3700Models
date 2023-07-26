using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class kds_kitchen_def
    {
        public int kds_kitchen_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public int? kds_primary_lan_node { get; set; }
        public int? kds_backup_lan_node { get; set; }
        public int? chit_prntr { get; set; }
        public int? backup_chit_prntr { get; set; }
        public int? wait_for_prep_suborders { get; set; }
        public string kds_post_file1 { get; set; }
        public string kds_post_file2 { get; set; }
        public string kds_post_file3 { get; set; }
        public string kds_post_exe { get; set; }
        public string kds_post_args { get; set; }
        public int? kds_post_interval { get; set; }
        public string kds_post_run_style { get; set; }
        public string kds_expo_recall_action { get; set; }
        public string ob_no_expo_before_prep_done { get; set; }
        public string ob_disp_non_app_after_app { get; set; }
        public string ob_rsvd01 { get; set; }
        public string ob_rsvd02 { get; set; }
        public string ob_rsvd03 { get; set; }
        public string ob_rsvd04 { get; set; }
        public string ob_rsvd05 { get; set; }
        public string ob_rsvd06 { get; set; }
        public string str_rsvd01 { get; set; }
        public string str_rsvd02 { get; set; }
        public string str_rsvd03 { get; set; }
        public string str_rsvd04 { get; set; }
        public int? num_rsvd { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public string ob_chit_prntr_is_pos { get; set; }
        public string ob_backup_chit_prntr_is_pos { get; set; }
        public int? se_port_seq { get; set; }
        public int number_of_zones { get; set; }
        public int max_items_per_zone { get; set; }
        public string production_count_inc_type { get; set; }
        public string production_count_dec_type { get; set; }
        public string item_started_timings { get; set; }
        public int? kds_fire_color { get; set; }
        public int? kds_sent_color { get; set; }
        public int? kds_bump_color { get; set; }
        public int? kds_panel_color { get; set; }
        public int? kds_grid_color { get; set; }
        public int? kds_selected_color { get; set; }
        public int? kds_active_color { get; set; }
        public int? kds_alert1_color { get; set; }
        public int? kds_alert2_color { get; set; }
        public int? kds_void_color { get; set; }
        public int? kds_item_color { get; set; }
        public string ob_incl_theme_in_pd_name { get; set; }
        public string ob_expo_only_display_as_done { get; set; }
        public int? kds_start_color { get; set; }
        public int? kds_item_select_color { get; set; }
        public int? kds_item_marked_color { get; set; }
        public int? kds_item_recalled_color { get; set; }
        public int? kds_item_recallable_color { get; set; }
        public string ob_enable_load_balancing { get; set; }
        public string ob_start_hides_other_preps { get; set; }
        public string ob_no_done_while_open_at_pos { get; set; }
    }
}
