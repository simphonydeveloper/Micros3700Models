using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class ts_style_def
    {
        public int ts_style_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public short? height { get; set; }
        public short? width { get; set; }
        public short font { get; set; }
        public short color_combo { get; set; }
        public string icon_placement { get; set; }
        public string ob_tss01_sort_keys { get; set; }
        public string ob_tss02_stay_down { get; set; }
        public string ob_tss03_cond { get; set; }
        public string ob_tss04_mi_count { get; set; }
        public string ob_tss05_slu_mask { get; set; }
        public string ob_rsvd02 { get; set; }
        public string ob_rsvd03 { get; set; }
        public string ob_rsvd04 { get; set; }
        public string ob_rsvd05 { get; set; }
        public string key_arrangement { get; set; }
        public int? template { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public short condiment_btn_color_combo { get; set; }
        public short condiment_btn_font { get; set; }
        public short? condiment_btn_width { get; set; }
        public short? condiment_btn_height { get; set; }
        public string condiment_arrangement { get; set; }
        public string condiment_icon_placement { get; set; }
        public short condiment_min_max_btn_color { get; set; }
        public short cond_required_ok_btn_color { get; set; }
        public short modifier_btn_color_combo { get; set; }
        public short modifier_btn_font { get; set; }
        public short? modifier_btn_width { get; set; }
        public short? modifier_btn_height { get; set; }
        public string modifier_arrangement { get; set; }
        public string modifier_icon_placement { get; set; }
        public short combo_item_btn_color_combo { get; set; }
        public short combo_item_btn_font { get; set; }
        public short? combo_item_btn_width { get; set; }
        public short? combo_item_btn_height { get; set; }
        public string combo_item_arrangement { get; set; }
        public string combo_item_icon_placement { get; set; }
        public short menu_level_btn_color_combo { get; set; }
        public short menu_level_btn_font { get; set; }
        public short? menu_level_btn_width { get; set; }
        public short? menu_level_btn_height { get; set; }
        public string menu_level_arrangement { get; set; }
        public string menu_level_type { get; set; }
    }
}
