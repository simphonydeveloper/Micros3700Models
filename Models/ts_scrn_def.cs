using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class ts_scrn_def
    {
        public int ts_scrn_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public int ts_layout_seq { get; set; }
        public string pos_type { get; set; }
        public string comments { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public int? default_slu_seq { get; set; }
        public string screen_type { get; set; }
        public string background_image { get; set; }
        public string animation_image { get; set; }
        public int? animation_speed { get; set; }
        public string media_file { get; set; }
        public string idle_media_file { get; set; }
        public int? idle_time { get; set; }
        public int? number_of_areas { get; set; }
        public string ob_em_store_managed { get; set; }
        public string ob_em_prevent_delete { get; set; }
        public string fixed_prompt_text { get; set; }
        public short quantity_btn_color_combo { get; set; }
        public short quantity_btn_font { get; set; }
        public short? quantity_btn_width { get; set; }
        public short? quantity_btn_height { get; set; }
        public string ob_hostess_mode { get; set; }
        public string ob_enable_make_key { get; set; }
        public string ob_enable_split_key { get; set; }
        public short? orientation_type { get; set; }
    }
}
